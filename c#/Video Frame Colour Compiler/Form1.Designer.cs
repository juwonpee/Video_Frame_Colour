namespace Video_Frame_Colour_Compiler
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.framesLabel = new System.Windows.Forms.Label();
            this.framesSubLabel = new System.Windows.Forms.Label();
            this.maxThreadLabel = new System.Windows.Forms.Label();
            this.videoLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.totalFramesLabel = new System.Windows.Forms.Label();
            this.numberThreadsLabel = new System.Windows.Forms.Label();
            this.progressLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.inputText = new System.Windows.Forms.TextBox();
            this.inputButton = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.TextBox();
            this.outputButton = new System.Windows.Forms.Button();
            this.framesText = new System.Windows.Forms.TextBox();
            this.maxThreadSubLabel = new System.Windows.Forms.Label();
            this.videoStatus = new System.Windows.Forms.Label();
            this.heightStatus = new System.Windows.Forms.Label();
            this.widthStatus = new System.Windows.Forms.Label();
            this.totalFramesStatus = new System.Windows.Forms.Label();
            this.numberThreadsStatus = new System.Windows.Forms.Label();
            this.statusStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.maxThreadNumber = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.inputDialog = new System.Windows.Forms.OpenFileDialog();
            this.outputDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.maxThreadNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputLabel.Location = new System.Drawing.Point(12, 40);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(95, 20);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Select video";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.outputLabel.Location = new System.Drawing.Point(12, 80);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(163, 20);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "Select output location";
            // 
            // framesLabel
            // 
            this.framesLabel.AutoSize = true;
            this.framesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.framesLabel.Location = new System.Drawing.Point(12, 120);
            this.framesLabel.Name = "framesLabel";
            this.framesLabel.Size = new System.Drawing.Size(192, 20);
            this.framesLabel.TabIndex = 0;
            this.framesLabel.Text = "Number of frames to scan";
            // 
            // framesSubLabel
            // 
            this.framesSubLabel.AutoSize = true;
            this.framesSubLabel.Location = new System.Drawing.Point(231, 145);
            this.framesSubLabel.Name = "framesSubLabel";
            this.framesSubLabel.Size = new System.Drawing.Size(126, 15);
            this.framesSubLabel.TabIndex = 0;
            this.framesSubLabel.Text = "Empty for whole video";
            // 
            // maxThreadLabel
            // 
            this.maxThreadLabel.AutoSize = true;
            this.maxThreadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maxThreadLabel.Location = new System.Drawing.Point(12, 170);
            this.maxThreadLabel.Name = "maxThreadLabel";
            this.maxThreadLabel.Size = new System.Drawing.Size(141, 20);
            this.maxThreadLabel.TabIndex = 0;
            this.maxThreadLabel.Text = "Number of threads";
            // 
            // videoLabel
            // 
            this.videoLabel.AutoSize = true;
            this.videoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.videoLabel.Location = new System.Drawing.Point(12, 250);
            this.videoLabel.Name = "videoLabel";
            this.videoLabel.Size = new System.Drawing.Size(58, 20);
            this.videoLabel.TabIndex = 0;
            this.videoLabel.Text = "Video: ";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.heightLabel.Location = new System.Drawing.Point(12, 280);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(60, 20);
            this.heightLabel.TabIndex = 0;
            this.heightLabel.Text = "Height:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.widthLabel.Location = new System.Drawing.Point(12, 310);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(58, 20);
            this.widthLabel.TabIndex = 0;
            this.widthLabel.Text = "Width: ";
            // 
            // totalFramesLabel
            // 
            this.totalFramesLabel.AutoSize = true;
            this.totalFramesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.totalFramesLabel.Location = new System.Drawing.Point(12, 340);
            this.totalFramesLabel.Name = "totalFramesLabel";
            this.totalFramesLabel.Size = new System.Drawing.Size(110, 20);
            this.totalFramesLabel.TabIndex = 0;
            this.totalFramesLabel.Text = "Total Frames: ";
            // 
            // numberThreadsLabel
            // 
            this.numberThreadsLabel.AutoSize = true;
            this.numberThreadsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numberThreadsLabel.Location = new System.Drawing.Point(12, 370);
            this.numberThreadsLabel.Name = "numberThreadsLabel";
            this.numberThreadsLabel.Size = new System.Drawing.Size(190, 20);
            this.numberThreadsLabel.TabIndex = 0;
            this.numberThreadsLabel.Text = "Number of active threads:";
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressLabel.Location = new System.Drawing.Point(12, 400);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(132, 20);
            this.progressLabel.TabIndex = 0;
            this.progressLabel.Text = "Current progress:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.statusLabel.Location = new System.Drawing.Point(12, 430);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(64, 20);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Status: ";
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(234, 40);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(218, 21);
            this.inputText.TabIndex = 1;
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(458, 40);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(75, 21);
            this.inputButton.TabIndex = 2;
            this.inputButton.Text = "Video";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(234, 80);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(218, 21);
            this.outputText.TabIndex = 3;
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(458, 80);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(75, 21);
            this.outputButton.TabIndex = 4;
            this.outputButton.Text = "Image";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // framesText
            // 
            this.framesText.Location = new System.Drawing.Point(234, 120);
            this.framesText.Name = "framesText";
            this.framesText.Size = new System.Drawing.Size(218, 21);
            this.framesText.TabIndex = 5;
            // 
            // maxThreadSubLabel
            // 
            this.maxThreadSubLabel.AutoSize = true;
            this.maxThreadSubLabel.Location = new System.Drawing.Point(231, 195);
            this.maxThreadSubLabel.Name = "maxThreadSubLabel";
            this.maxThreadSubLabel.Size = new System.Drawing.Size(117, 15);
            this.maxThreadSubLabel.TabIndex = 0;
            this.maxThreadSubLabel.Text = "Empty for maximum";
            // 
            // videoStatus
            // 
            this.videoStatus.AutoSize = true;
            this.videoStatus.Location = new System.Drawing.Point(231, 250);
            this.videoStatus.Name = "videoStatus";
            this.videoStatus.Size = new System.Drawing.Size(11, 15);
            this.videoStatus.TabIndex = 0;
            this.videoStatus.Text = "-";
            // 
            // heightStatus
            // 
            this.heightStatus.AutoSize = true;
            this.heightStatus.Location = new System.Drawing.Point(231, 280);
            this.heightStatus.Name = "heightStatus";
            this.heightStatus.Size = new System.Drawing.Size(11, 15);
            this.heightStatus.TabIndex = 0;
            this.heightStatus.Text = "-";
            // 
            // widthStatus
            // 
            this.widthStatus.AutoSize = true;
            this.widthStatus.Location = new System.Drawing.Point(231, 310);
            this.widthStatus.Name = "widthStatus";
            this.widthStatus.Size = new System.Drawing.Size(11, 15);
            this.widthStatus.TabIndex = 0;
            this.widthStatus.Text = "-";
            // 
            // totalFramesStatus
            // 
            this.totalFramesStatus.AutoSize = true;
            this.totalFramesStatus.Location = new System.Drawing.Point(231, 340);
            this.totalFramesStatus.Name = "totalFramesStatus";
            this.totalFramesStatus.Size = new System.Drawing.Size(11, 15);
            this.totalFramesStatus.TabIndex = 0;
            this.totalFramesStatus.Text = "-";
            // 
            // numberThreadsStatus
            // 
            this.numberThreadsStatus.AutoSize = true;
            this.numberThreadsStatus.Location = new System.Drawing.Point(231, 370);
            this.numberThreadsStatus.Name = "numberThreadsStatus";
            this.numberThreadsStatus.Size = new System.Drawing.Size(11, 15);
            this.numberThreadsStatus.TabIndex = 0;
            this.numberThreadsStatus.Text = "-";
            // 
            // statusStatus
            // 
            this.statusStatus.AutoSize = true;
            this.statusStatus.Location = new System.Drawing.Point(231, 430);
            this.statusStatus.Name = "statusStatus";
            this.statusStatus.Size = new System.Drawing.Size(11, 15);
            this.statusStatus.TabIndex = 0;
            this.statusStatus.Text = "-";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(234, 400);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(299, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // maxThreadNumber
            // 
            this.maxThreadNumber.Location = new System.Drawing.Point(234, 170);
            this.maxThreadNumber.Name = "maxThreadNumber";
            this.maxThreadNumber.Size = new System.Drawing.Size(120, 21);
            this.maxThreadNumber.TabIndex = 6;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 486);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(93, 486);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(174, 486);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 9;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            // 
            // inputDialog
            // 
            this.inputDialog.DefaultExt = "mov, mp4, avi";
            // 
            // outputDialog
            // 
            this.outputDialog.DefaultExt = "png";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 551);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.maxThreadNumber);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.statusStatus);
            this.Controls.Add(this.numberThreadsStatus);
            this.Controls.Add(this.totalFramesStatus);
            this.Controls.Add(this.widthStatus);
            this.Controls.Add(this.heightStatus);
            this.Controls.Add(this.videoStatus);
            this.Controls.Add(this.maxThreadSubLabel);
            this.Controls.Add(this.framesText);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.numberThreadsLabel);
            this.Controls.Add(this.totalFramesLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.videoLabel);
            this.Controls.Add(this.maxThreadLabel);
            this.Controls.Add(this.framesSubLabel);
            this.Controls.Add(this.framesLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Video Frame Colour Compiler";
            ((System.ComponentModel.ISupportInitialize)(this.maxThreadNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label framesLabel;
        private System.Windows.Forms.Label framesSubLabel;
        private System.Windows.Forms.Label maxThreadLabel;
        private System.Windows.Forms.Label videoLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label totalFramesLabel;
        private System.Windows.Forms.Label numberThreadsLabel;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.TextBox framesText;
        private System.Windows.Forms.Label maxThreadSubLabel;
        private System.Windows.Forms.Label videoStatus;
        private System.Windows.Forms.Label heightStatus;
        private System.Windows.Forms.Label widthStatus;
        private System.Windows.Forms.Label totalFramesStatus;
        private System.Windows.Forms.Label numberThreadsStatus;
        private System.Windows.Forms.Label statusStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown maxThreadNumber;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.OpenFileDialog inputDialog;
        private System.Windows.Forms.SaveFileDialog outputDialog;
    }
}

