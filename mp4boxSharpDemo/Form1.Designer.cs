namespace mp4boxSharpDemo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonSelectDestinationAsync = new System.Windows.Forms.Button();
            this.buttonSelectSourcesAsync = new System.Windows.Forms.Button();
            this.richTextBoxLogAsync = new System.Windows.Forms.RichTextBox();
            this.textBoxDestinationAsync = new System.Windows.Forms.TextBox();
            this.textBoxSourcesAsync = new System.Windows.Forms.TextBox();
            this.buttonStartConcatinationAsync = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonSelectDestinationSync = new System.Windows.Forms.Button();
            this.buttonSelectSourcesSync = new System.Windows.Forms.Button();
            this.richTextBoxLogSync = new System.Windows.Forms.RichTextBox();
            this.textBoxDestinationSync = new System.Windows.Forms.TextBox();
            this.textBoxSourcesSync = new System.Windows.Forms.TextBox();
            this.buttonStartConcatinationSync = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(868, 337);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.buttonSelectDestinationAsync);
            this.tabPage1.Controls.Add(this.buttonSelectSourcesAsync);
            this.tabPage1.Controls.Add(this.richTextBoxLogAsync);
            this.tabPage1.Controls.Add(this.textBoxDestinationAsync);
            this.tabPage1.Controls.Add(this.textBoxSourcesAsync);
            this.tabPage1.Controls.Add(this.buttonStartConcatinationAsync);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(860, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Async Concat Mp4s";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 261);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(663, 41);
            this.progressBar1.TabIndex = 12;
            // 
            // buttonSelectDestinationAsync
            // 
            this.buttonSelectDestinationAsync.Location = new System.Drawing.Point(715, 32);
            this.buttonSelectDestinationAsync.Name = "buttonSelectDestinationAsync";
            this.buttonSelectDestinationAsync.Size = new System.Drawing.Size(119, 20);
            this.buttonSelectDestinationAsync.TabIndex = 11;
            this.buttonSelectDestinationAsync.Text = "SelectDestination";
            this.buttonSelectDestinationAsync.UseVisualStyleBackColor = true;
            this.buttonSelectDestinationAsync.Click += new System.EventHandler(this.buttonSelectDestinationAsync_Click);
            // 
            // buttonSelectSourcesAsync
            // 
            this.buttonSelectSourcesAsync.Location = new System.Drawing.Point(716, 6);
            this.buttonSelectSourcesAsync.Name = "buttonSelectSourcesAsync";
            this.buttonSelectSourcesAsync.Size = new System.Drawing.Size(118, 20);
            this.buttonSelectSourcesAsync.TabIndex = 10;
            this.buttonSelectSourcesAsync.Text = "SelectSources";
            this.buttonSelectSourcesAsync.UseVisualStyleBackColor = true;
            this.buttonSelectSourcesAsync.Click += new System.EventHandler(this.buttonSelectSourcesAsync_Click);
            // 
            // richTextBoxLogAsync
            // 
            this.richTextBoxLogAsync.Location = new System.Drawing.Point(9, 59);
            this.richTextBoxLogAsync.Name = "richTextBoxLogAsync";
            this.richTextBoxLogAsync.Size = new System.Drawing.Size(843, 196);
            this.richTextBoxLogAsync.TabIndex = 9;
            this.richTextBoxLogAsync.Text = "";
            // 
            // textBoxDestinationAsync
            // 
            this.textBoxDestinationAsync.Location = new System.Drawing.Point(9, 33);
            this.textBoxDestinationAsync.Name = "textBoxDestinationAsync";
            this.textBoxDestinationAsync.Size = new System.Drawing.Size(700, 20);
            this.textBoxDestinationAsync.TabIndex = 8;
            // 
            // textBoxSourcesAsync
            // 
            this.textBoxSourcesAsync.Location = new System.Drawing.Point(9, 6);
            this.textBoxSourcesAsync.Name = "textBoxSourcesAsync";
            this.textBoxSourcesAsync.Size = new System.Drawing.Size(701, 20);
            this.textBoxSourcesAsync.TabIndex = 7;
            // 
            // buttonStartConcatinationAsync
            // 
            this.buttonStartConcatinationAsync.Location = new System.Drawing.Point(678, 261);
            this.buttonStartConcatinationAsync.Name = "buttonStartConcatinationAsync";
            this.buttonStartConcatinationAsync.Size = new System.Drawing.Size(174, 41);
            this.buttonStartConcatinationAsync.TabIndex = 6;
            this.buttonStartConcatinationAsync.Text = "Start Concatination";
            this.buttonStartConcatinationAsync.UseVisualStyleBackColor = true;
            this.buttonStartConcatinationAsync.Click += new System.EventHandler(this.buttonStartConcatinationAsync_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonSelectDestinationSync);
            this.tabPage2.Controls.Add(this.buttonSelectSourcesSync);
            this.tabPage2.Controls.Add(this.richTextBoxLogSync);
            this.tabPage2.Controls.Add(this.textBoxDestinationSync);
            this.tabPage2.Controls.Add(this.textBoxSourcesSync);
            this.tabPage2.Controls.Add(this.buttonStartConcatinationSync);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(518, 308);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sync Concat Mp4s";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // buttonSelectDestinationSync
            // 
            this.buttonSelectDestinationSync.Location = new System.Drawing.Point(210, 70);
            this.buttonSelectDestinationSync.Name = "buttonSelectDestinationSync";
            this.buttonSelectDestinationSync.Size = new System.Drawing.Size(119, 20);
            this.buttonSelectDestinationSync.TabIndex = 5;
            this.buttonSelectDestinationSync.Text = "SelectDestination";
            this.buttonSelectDestinationSync.UseVisualStyleBackColor = true;
            this.buttonSelectDestinationSync.Click += new System.EventHandler(this.buttonSelectDestination_Click);
            // 
            // buttonSelectSourcesSync
            // 
            this.buttonSelectSourcesSync.Location = new System.Drawing.Point(211, 27);
            this.buttonSelectSourcesSync.Name = "buttonSelectSourcesSync";
            this.buttonSelectSourcesSync.Size = new System.Drawing.Size(118, 20);
            this.buttonSelectSourcesSync.TabIndex = 4;
            this.buttonSelectSourcesSync.Text = "SelectSources";
            this.buttonSelectSourcesSync.UseVisualStyleBackColor = true;
            this.buttonSelectSourcesSync.Click += new System.EventHandler(this.buttonSelectSources_Click);
            // 
            // richTextBoxLogSync
            // 
            this.richTextBoxLogSync.Location = new System.Drawing.Point(20, 163);
            this.richTextBoxLogSync.Name = "richTextBoxLogSync";
            this.richTextBoxLogSync.Size = new System.Drawing.Size(243, 116);
            this.richTextBoxLogSync.TabIndex = 3;
            this.richTextBoxLogSync.Text = "";
            // 
            // textBoxDestinationSync
            // 
            this.textBoxDestinationSync.Location = new System.Drawing.Point(32, 70);
            this.textBoxDestinationSync.Name = "textBoxDestinationSync";
            this.textBoxDestinationSync.Size = new System.Drawing.Size(172, 20);
            this.textBoxDestinationSync.TabIndex = 2;
            // 
            // textBoxSourcesSync
            // 
            this.textBoxSourcesSync.Location = new System.Drawing.Point(32, 27);
            this.textBoxSourcesSync.Name = "textBoxSourcesSync";
            this.textBoxSourcesSync.Size = new System.Drawing.Size(173, 20);
            this.textBoxSourcesSync.TabIndex = 1;
            // 
            // buttonStartConcatinationSync
            // 
            this.buttonStartConcatinationSync.Location = new System.Drawing.Point(289, 199);
            this.buttonStartConcatinationSync.Name = "buttonStartConcatinationSync";
            this.buttonStartConcatinationSync.Size = new System.Drawing.Size(174, 50);
            this.buttonStartConcatinationSync.TabIndex = 0;
            this.buttonStartConcatinationSync.Text = "Start Concatination";
            this.buttonStartConcatinationSync.UseVisualStyleBackColor = true;
            this.buttonStartConcatinationSync.Click += new System.EventHandler(this.buttonStartSyncConcatination_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            this.openFileDialog2.Multiselect = true;
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog2_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 337);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Mp4BoxDemo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonSelectDestinationSync;
        private System.Windows.Forms.Button buttonSelectSourcesSync;
        private System.Windows.Forms.RichTextBox richTextBoxLogSync;
        private System.Windows.Forms.TextBox textBoxDestinationSync;
        private System.Windows.Forms.TextBox textBoxSourcesSync;
        private System.Windows.Forms.Button buttonStartConcatinationSync;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonSelectDestinationAsync;
        private System.Windows.Forms.Button buttonSelectSourcesAsync;
        private System.Windows.Forms.RichTextBox richTextBoxLogAsync;
        private System.Windows.Forms.TextBox textBoxDestinationAsync;
        private System.Windows.Forms.TextBox textBoxSourcesAsync;
        private System.Windows.Forms.Button buttonStartConcatinationAsync;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

