using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Management;

namespace Video_Frame_Colour_Compiler
{
    public partial class Form1 : Form
    {
        
        // instanciate opencv
        mainClass mainThread = new mainClass();

        public Form1()
        {
            InitializeComponent();
            maxThreadNumber.Minimum = 1;
            maxThreadNumber.Maximum = mainThread.getMaxThreads();
            maxThreadNumber.Value = Environment.ProcessorCount;
            maxThreadSubLabel.Text = "Max: " + Environment.ProcessorCount.ToString();

        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            inputDialog.ShowDialog();
            if (mainThread.setInputVideo(inputDialog.FileName))
            {
                statusStatus.Text = "Imported video";
                inputText.Text = inputDialog.FileName;
                videoStatus.Text = inputDialog.FileName;
                heightStatus.Text = mainThread.getHeight().ToString();
                widthStatus.Text = mainThread.getWidth().ToString();
                totalFramesStatus.Text = mainThread.getLength().ToString();
            }

            else
            {
                statusStatus.Text = "Video format not supported or corrupted";
            }


        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            outputDialog.ShowDialog();
            outputText.Text = outputDialog.FileName;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            int result;
            result = mainThread.starter();
            if (result == 0)
            {
                statusStatus.Text = "Completed Sucessfully";
            }
            else if (result == -1)
            {
                statusStatus.Text = "Video not imported";
            }
            else if (result == -2)
            {
                statusStatus.Text = "Error while compiling";
            }
        }
    }
}
