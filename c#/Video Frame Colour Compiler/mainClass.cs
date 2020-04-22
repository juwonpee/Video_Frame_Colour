using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenCvSharp;
using System.Management;
using System.Runtime.Remoting.Messaging;

namespace Video_Frame_Colour_Compiler
{
    class mainClass
    {
        int maxThreadCount;
        bool inputCorrect;
        VideoCapture videoReader;
        Mat frame;
        int currentFrame;

        // consturctor
        public mainClass () 
        {
            maxThreadCount = Environment.ProcessorCount;
        }

        public bool setInputVideo(String fileName) 
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

        public int starter() 
        {
            // 0: compiled correctly
            // -1 video not loaded properly
            // -2 compilation error
            Thread compiler = new Thread(compile);
            if (inputCorrect == true)
            {
                try
                {
                    compiler.Start();
                    return 0;
                }
                catch
                {

                    return -2;
                }
            }
            else
            {
                return -1;
            }
        }

        public void compile () 
        {
            for (int i = 0; i < videoReader.FrameCount; i++) 
            {
                videoReader.Set(1, i);
                currentFrame = i;
                videoReader.Read(frame);
                if (frame.Empty())
                {
                    throw new System.ArgumentException("Frame empty or corrupted");
                }


            }
        }

        public bool writer(String fileName)
        {
            return true;
        }
        public bool getInputCorrect() { return inputCorrect; }
        public int getMaxThreads() { return maxThreadCount; }
        public int getHeight() { return videoReader.FrameHeight; }
        public int getWidth() { return videoReader.FrameWidth; }
        public int getLength() { return videoReader.FrameCount; }
        public int getCurrentFrame() { return currentFrame; }
    }
}
