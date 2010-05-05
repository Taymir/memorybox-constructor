namespace Constructor
{
    partial class Compile
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.total_progress = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.step_counter = new System.Windows.Forms.Label();
            this.current_text = new System.Windows.Forms.Label();
            this.total_text = new System.Windows.Forms.Label();
            this.current_progress = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.step_one_bw = new System.ComponentModel.BackgroundWorker();
            this.step_two_bw = new System.ComponentModel.BackgroundWorker();
            this.step_three_bw = new System.ComponentModel.BackgroundWorker();
            this.step_four_bw = new System.ComponentModel.BackgroundWorker();
            this.step_five_bw = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 261);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(801, 223);
            this.textBox1.TabIndex = 0;
            // 
            // total_progress
            // 
            this.total_progress.Location = new System.Drawing.Point(12, 96);
            this.total_progress.Maximum = 5;
            this.total_progress.Minimum = 1;
            this.total_progress.Name = "total_progress";
            this.total_progress.Size = new System.Drawing.Size(805, 23);
            this.total_progress.TabIndex = 1;
            this.total_progress.Value = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сборка проекта:  Шаг";
            // 
            // step_counter
            // 
            this.step_counter.AutoSize = true;
            this.step_counter.Location = new System.Drawing.Point(125, 13);
            this.step_counter.Name = "step_counter";
            this.step_counter.Size = new System.Drawing.Size(0, 13);
            this.step_counter.TabIndex = 3;
            // 
            // current_text
            // 
            this.current_text.AutoSize = true;
            this.current_text.Location = new System.Drawing.Point(9, 142);
            this.current_text.Name = "current_text";
            this.current_text.Size = new System.Drawing.Size(0, 13);
            this.current_text.TabIndex = 4;
            // 
            // total_text
            // 
            this.total_text.AutoSize = true;
            this.total_text.Location = new System.Drawing.Point(13, 80);
            this.total_text.Name = "total_text";
            this.total_text.Size = new System.Drawing.Size(0, 13);
            this.total_text.TabIndex = 5;
            // 
            // current_progress
            // 
            this.current_progress.Location = new System.Drawing.Point(12, 168);
            this.current_progress.Name = "current_progress";
            this.current_progress.Size = new System.Drawing.Size(805, 23);
            this.current_progress.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Детали >>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // step_one_bw
            // 
            this.step_one_bw.WorkerReportsProgress = true;
            this.step_one_bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.step_one_bw_DoWork);
            this.step_one_bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.step_one_bw_RunWorkerCompleted);
            this.step_one_bw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_ProgressChanged);
            // 
            // step_two_bw
            // 
            this.step_two_bw.WorkerReportsProgress = true;
            this.step_two_bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.step_two_bw_DoWork);
            this.step_two_bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.step_two_bw_RunWorkerCompleted);
            this.step_two_bw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_ProgressChanged);
            // 
            // step_three_bw
            // 
            this.step_three_bw.WorkerReportsProgress = true;
            this.step_three_bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.step_three_bw_DoWork);
            this.step_three_bw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_ProgressChanged);
            // 
            // step_four_bw
            // 
            this.step_four_bw.WorkerReportsProgress = true;
            this.step_four_bw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_ProgressChanged);
            // 
            // Compile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 248);
            this.Controls.Add(this.current_progress);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.total_text);
            this.Controls.Add(this.current_text);
            this.Controls.Add(this.step_counter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.total_progress);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Compile";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Сборка проекта";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Compile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar total_progress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label step_counter;
        private System.Windows.Forms.Label current_text;
        private System.Windows.Forms.Label total_text;
        private System.Windows.Forms.ProgressBar current_progress;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker step_one_bw;
        private System.ComponentModel.BackgroundWorker step_two_bw;
        private System.ComponentModel.BackgroundWorker step_three_bw;
        private System.ComponentModel.BackgroundWorker step_four_bw;
        private System.ComponentModel.BackgroundWorker step_five_bw;
    }
}