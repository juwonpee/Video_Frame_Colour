using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Management;

namespace Video_Frame_Colour_Compiler
{
    public partial class Form1 : Form
    {
        
        // instanciate opencv
        mainClass opencvEngine = new mainClass();

        public Form1()
        {
            InitializeComponent();
            selectThreadNumber.Minimum = 1;
            selectThreadNumber.Maximum = opencvEngine.getMaxThreads();
            selectThreadNumber.Value = Environment.ProcessorCount;
            maxThreadSubLabel.Text = "Max: " + Environment.ProcessorCount.ToString();

        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            inputDialog.ShowDialog();
            if (opencvEngine.setInputVideo(inputDialog.FileName))
            {
                statusStatus.Text = "Imported video";
                inputText.Text = inputDialog.FileName;
                videoStatus.Text = inputDialog.FileName;
                heightStatus.Text = opencvEngine.getHeight().ToString();
                widthStatus.Text = opencvEngine.getWidth().ToString();
                totalFramesStatus.Text = opencvEngine.getLength().ToString();
            }

            else
            {
                statusStatus.Text = "Video format not supported or corrupted";
            }


        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            outputDialog.ShowDialog();
            if (opencvEngine.setOutputFile(outputDialog.FileName))
            {
                statusStatus.Text = "Selected output file";
                outputText.Text = outputDialog.FileName;
            }
            outputText.Text = outputDialog.FileName;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            int result;
            result = opencvEngine.starter(Decimal.ToInt32(selectThreadNumber.Value));
            if (result == 0) { statusStatus.Text = "running"; }
            else if (result == -1) { statusStatus.Text = "Video not imported"; }
            else if (result == -2) { statusStatus.Text = "Output location not set"; }
    }

        private void progress_Updater(int currentProgress)
        {
            progressBar.Minimum = 0;
            progressBar.Maximum = opencvEngine.getCurrentFrame();
        }
    }
}
