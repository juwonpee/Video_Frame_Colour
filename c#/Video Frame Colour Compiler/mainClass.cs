using System;
using System.Threading;
using OpenCvSharp;

namespace Video_Frame_Colour_Compiler
{
    class mainClass
    { 
        int maxThreadCount;
        int threadCount;
        bool inputCorrect = false;
        bool outputCorrect = false;
        VideoCapture videoReader;
        String outputFile;
        Mat frame = new Mat();
        int currentFrame = 0;
        Vec3b[] values;

        // consturctor
        public mainClass () 
        {
            maxThreadCount = Environment.ProcessorCount;
        }

        public bool setInputVideo(string fileName) 
        {
            videoReader = new VideoCapture(fileName);
            if (videoReader.IsOpened()) 
            {
                inputCorrect = true;
            }
            else {
                inputCorrect = false;
                videoReader.Release();
            }
            return inputCorrect;
        }

        public bool setOutputFile(string fileName)
        {
            outputFile = fileName;
            outputCorrect = true;
            return true;
        }

        public int starter(int selectThreadCount) 
        {
            threadCount = selectThreadCount;
            // 0: running
            // -1 video not loaded properly
            // -2 compilation error
            if (inputCorrect == true & outputCorrect == true)
            {
                Thread compiler = new Thread(calculate);
                compiler.Name = "Task distributor";
                compiler.Start();
                return 0;
            }
            else if (inputCorrect == false) { return -1; }
            else if (outputCorrect = false) { return -2; }
            else { return -3; }
        }

        public void calculate () 
        {
            /* --------------------------------TODO--------------------------------
             * Memory usage depends on the length of video therefore need to split up video in sections
             * When finished with each section, write to file then move onto next section
             * Aim for 200mb max memory usage
             */
            values = new Vec3b[getLength()];
            bool endFlag = false;

            for (int i = 0; i < getLength(); i = i + threadCount)                       // multithreading madness
            {
                Thread[] calculator = new Thread[threadCount];
                for (int j = 0; j < threadCount; j ++)
                {

                    currentFrame = i + j;
                    if (currentFrame >= getLength()) { break; }
                    videoReader.Set(1, i+ j);
                    videoReader.Read(frame);
                    Mat localFrame = frame;                                                        // some wierd c# quirks https://docs.microsoft.com/en-us/archive/blogs/ericlippert/closing-over-the-loop-variable-considered-harmful
                    int localFrameCount = i + j;
                    calculator[j] = new Thread(() => rgbCalculator(localFrame, localFrameCount));
                    calculator[j].Name = "Calculator: " + (i + j).ToString();
                    calculator[j].Start();
                }
                for (int k = 0; k < threadCount; k++)                                              // stop making too many threads and thread object being overwritten
                {
                    if (currentFrame >= getLength()) { break; }
                    calculator[k].Join();
                }
            }
            Console.WriteLine("________Completed________");
            writer();
        }

        public void rgbCalculator (Mat stillFrame, int frameNumber)
        {
            Vec3b value;
            var optFrame = new Mat<Vec3b>(stillFrame);                                             // data access optimization https://github.com/shimat/opencvsharp/wiki/Accessing-Pixel#typespecificmat-faster
            var indexer = optFrame.GetIndexer();
            double r = 0; double g = 0; double b = 0;
            for (int x = 0; x < stillFrame.Width; x++)                                             // horizontal
            {
                for (int y = 0; y < stillFrame.Height; y++)                                        // vertical
                {
                    Vec3b pixel = indexer[y, x];
                    b += pixel.Item0;
                    g += pixel.Item1;
                    r += pixel.Item2;
                }
            }
            value.Item0 = (byte) (b / (videoReader.FrameWidth * videoReader.FrameHeight));
            value.Item1 = (byte) (g / (videoReader.FrameWidth * videoReader.FrameHeight));
            value.Item2 = (byte) (r / (videoReader.FrameWidth * videoReader.FrameHeight));
            values[frameNumber] = value;
            Console.WriteLine("Frame Number: " + frameNumber.ToString() + " Values: " + value);
        }

        public void writer()
        {
            String outputText = "Frame No | Red   Blue  Green\n";
            int i = 0;
            foreach (Vec3b pixel in values)
            {
                outputText = outputText + (i.ToString() + ":").PadRight(7, ' ') + (pixel.Item2.ToString() + ",").PadRight(7, ' ') + (pixel.Item1.ToString() + ",").PadRight(7, ' ') + (pixel.Item0.ToString() + ",").PadRight(7, ' ') + "\n";
                i++;
            }
            System.IO.File.WriteAllText(@outputFile, outputText);
            values = new Vec3b[0];
            System.GC.Collect();                                                                   // force garbage collection
        }
        public bool getInputCorrect() { return inputCorrect; }
        public int getMaxThreads() { return maxThreadCount; }
        public int getHeight() { return videoReader.FrameHeight; }
        public int getWidth() { return videoReader.FrameWidth; }
        public int getLength() { return videoReader.FrameCount; }
        public int getCurrentFrame() { return currentFrame; }
    }
}
