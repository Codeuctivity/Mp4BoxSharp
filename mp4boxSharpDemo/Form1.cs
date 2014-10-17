using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace mp4boxSharpDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSelectSources_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (openFileDialog1.CheckFileExists)
            {
                foreach (var item in openFileDialog1.FileNames)
                {
                    textBoxSourcesSync.Text += item + ";";
                }
            }
        }

        private void buttonSelectDestination_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBoxDestinationSync.Text += saveFileDialog1.FileName;
        }

        private mp4boxSharp.mp4BoxSharpSync mp4boxSharp = new mp4boxSharp.mp4BoxSharpSync();

        private void buttonStartSyncConcatination_Click(object sender, EventArgs e)
        {
            List<Uri> destinations = new List<Uri>();
            foreach (var item in openFileDialog1.FileNames)
            {
                destinations.Add(new Uri(item));
            }

            richTextBoxLogSync.Clear();

            if (mp4boxSharp.concatMp4s(destinations, new Uri(textBoxDestinationSync.Text)))
            {
                richTextBoxLogSync.Text += "Succsess\n";
            }
            else
            {
                richTextBoxLogSync.Text += "Failed\n";
                richTextBoxLogSync.Text += mp4boxSharp.standardError + "\n";
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void buttonSelectSourcesAsync_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void buttonSelectDestinationAsync_Click(object sender, EventArgs e)
        {
            saveFileDialog2.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            if (openFileDialog2.CheckFileExists)
            {
                foreach (var item in openFileDialog2.FileNames)
                {
                    textBoxSourcesAsync.Text += item + ";";
                }
            }
        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            textBoxDestinationAsync.Text += saveFileDialog2.FileName;
        }

        private mp4boxSharp.mp4BoxSharpAsync mp4BoxSharpAsync = new mp4boxSharp.mp4BoxSharpAsync();

        private void buttonStartConcatinationAsync_Click(object sender, EventArgs e)
        {
            List<Uri> destinations = new List<Uri>();
            foreach (var item in openFileDialog2.FileNames)
                destinations.Add(new Uri(item));
            richTextBoxLogAsync.Clear();
            mp4BoxSharpAsync.startConcatAsync(destinations, new Uri(textBoxDestinationAsync.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mp4BoxSharpAsync.Progress += mp4BoxSharpAsync_Progress;
            mp4BoxSharpAsync.Finished += mp4BoxSharpAsync_Finished;
        }

        private void mp4BoxSharpAsync_Finished(object sender, EventArgs e)
        {

            richTextBoxLogAsync.Text += mp4BoxSharpAsync.result;
        }

        private void mp4BoxSharpAsync_Progress(object sender, EventArgs e)
        {
            progressBar1.Value = mp4BoxSharpAsync.progress;
        }
    }
}