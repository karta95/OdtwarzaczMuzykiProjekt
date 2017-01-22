using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;
using VideoLibrary;
using System.IO;

namespace OdtwarzaczMuzyki
{
    public partial class oknoPobierania : Form
    {
        public oknoPobierania()
        {
            InitializeComponent();
        }

        private void wyborSciezkiButton_Click(object sender, EventArgs e)
        {

        }

        private void wybierzSciezkebutton_Click(object sender, EventArgs e)
        {
            SaveFileDialog okno = new SaveFileDialog();
            okno.ShowDialog();

            wyswietlenieSciezkiLabel.Text = okno.FileName;
        }

        private void pobierzUtworButton_Click(object sender, EventArgs e)
        {
            if (urlTextBox.Text != "")
            {
                var youTube = YouTube.Default; 
                var video = youTube.GetVideo(urlTextBox.Text);
                File.WriteAllBytes(wyswietlenieSciezkiLabel.Text, video.GetBytes());
                MessageBox.Show("Pobrano plik!");
            }



        }
    }
}
