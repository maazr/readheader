namespace FFILEHEADER
{
    partial class FormMain
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
            this.listBoxSrc = new System.Windows.Forms.ListBox();
            this.listBoxChng = new System.Windows.Forms.ListBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.tbSelectedFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelcolcount = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.listControl = new System.Windows.Forms.ListBox();
            this.buttonBuildFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSrc
            // 
            this.listBoxSrc.FormattingEnabled = true;
            this.listBoxSrc.ItemHeight = 20;
            this.listBoxSrc.Location = new System.Drawing.Point(24, 81);
            this.listBoxSrc.Name = "listBoxSrc";
            this.listBoxSrc.Size = new System.Drawing.Size(279, 584);
            this.listBoxSrc.TabIndex = 0;
            // 
            // listBoxChng
            // 
            this.listBoxChng.FormattingEnabled = true;
            this.listBoxChng.ItemHeight = 20;
            this.listBoxChng.Location = new System.Drawing.Point(351, 81);
            this.listBoxChng.Name = "listBoxChng";
            this.listBoxChng.Size = new System.Drawing.Size(279, 284);
            this.listBoxChng.TabIndex = 0;
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 20;
            this.listBoxResult.Location = new System.Drawing.Point(677, 81);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(279, 584);
            this.listBoxResult.TabIndex = 0;
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Location = new System.Drawing.Point(24, 23);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(125, 32);
            this.buttonReadFile.TabIndex = 1;
            this.buttonReadFile.Text = "Read File";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(191, 23);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(125, 32);
            this.buttonProcess.TabIndex = 1;
            this.buttonProcess.Text = "Process";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(557, 23);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(125, 32);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // openFD
            // 
            this.openFD.DefaultExt = "csv";
            // 
            // tbSelectedFile
            // 
            this.tbSelectedFile.Location = new System.Drawing.Point(153, 677);
            this.tbSelectedFile.Name = "tbSelectedFile";
            this.tbSelectedFile.ReadOnly = true;
            this.tbSelectedFile.Size = new System.Drawing.Size(803, 26);
            this.tbSelectedFile.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 680);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selected File:";
            // 
            // labelcolcount
            // 
            this.labelcolcount.AutoSize = true;
            this.labelcolcount.Location = new System.Drawing.Point(704, 29);
            this.labelcolcount.Name = "labelcolcount";
            this.labelcolcount.Size = new System.Drawing.Size(121, 20);
            this.labelcolcount.TabIndex = 4;
            this.labelcolcount.Text = "# of column(s) : ";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(843, 29);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(52, 20);
            this.labelCount.TabIndex = 5;
            this.labelCount.Text = "Count";
            // 
            // listControl
            // 
            this.listControl.FormattingEnabled = true;
            this.listControl.ItemHeight = 20;
            this.listControl.Location = new System.Drawing.Point(351, 381);
            this.listControl.Name = "listControl";
            this.listControl.Size = new System.Drawing.Size(279, 284);
            this.listControl.TabIndex = 0;
            // 
            // buttonBuildFile
            // 
            this.buttonBuildFile.Location = new System.Drawing.Point(351, 23);
            this.buttonBuildFile.Name = "buttonBuildFile";
            this.buttonBuildFile.Size = new System.Drawing.Size(125, 32);
            this.buttonBuildFile.TabIndex = 1;
            this.buttonBuildFile.Text = "Build File";
            this.buttonBuildFile.UseVisualStyleBackColor = true;
            this.buttonBuildFile.Click += new System.EventHandler(this.buttonBuildFile_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 720);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelcolcount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSelectedFile);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonBuildFile);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.buttonReadFile);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.listControl);
            this.Controls.Add(this.listBoxChng);
            this.Controls.Add(this.listBoxSrc);
            this.Name = "FormMain";
            this.Text = "Change File Header";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSrc;
        private System.Windows.Forms.ListBox listBoxChng;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button buttonReadFile;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.TextBox tbSelectedFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelcolcount;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.ListBox listControl;
        private System.Windows.Forms.Button buttonBuildFile;
    }
}

