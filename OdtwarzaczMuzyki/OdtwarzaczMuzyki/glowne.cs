using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;

namespace OdtwarzaczMuzyki
{
    public partial class glowne : Form
    {
        oknoEdycji _oknoEdycji;
        oknoPobierania _oknoPobierania;
        oknoLogowania _oknoLogowania;
        oknoDodaniaPlaylisty _oknoDodaniaPlaylisty;
        BazaDanych baza = new BazaDanych();
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public glowne()
        {
            InitializeComponent();
            OdswiezPlaylisty();
        }

        private void main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet3.Utwory' table. You can move, or remove it, as needed.
            this.utworyTableAdapter1.Fill(this.databaseDataSet3.Utwory);
            // TODO: This line of code loads data into the 'playlistyBinding.Playlista' table. You can move, or remove it, as needed.
            this.playlistaTableAdapter1.Fill(this.playlistyBinding.Playlista);
            // TODO: This line of code loads data into the 'databaseDataSet1.Playlista' table. You can move, or remove it, as needed.
            this.playlistaTableAdapter.Fill(this.databaseDataSet1.Playlista);

        }

        private void main_Resize(object sender, EventArgs e)
        {
    
        }

        private void mójProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _oknoEdycji = new oknoEdycji();
            _oknoEdycji.ShowDialog();
        }

        private void pobierzZYouTubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _oknoPobierania = new oknoPobierania();
            _oknoPobierania.ShowDialog();
        }

        private void logowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _oknoLogowania = new oknoLogowania();
            _oknoLogowania.ShowDialog();
        }

        private void dodajPlaylisteButton_Click(object sender, EventArgs e)
        {
            _oknoDodaniaPlaylisty = new oknoDodaniaPlaylisty();
            _oknoDodaniaPlaylisty.ShowDialog();
            OdswiezPlaylisty();
        }

        private void usunPlaylisteButton_Click(object sender, EventArgs e)
        {
            int idPlaylisty;
            if (dataGridPlaylisty.CurrentRow.Index >= 0)
            {
                idPlaylisty = (int)dataGridPlaylisty.Rows[dataGridPlaylisty.CurrentRow.Index].Cells[0].Value;
                baza.UsunPlayliste(idPlaylisty);
            }
            OdswiezPlaylisty();
        }

        void OdswiezPlaylisty()
        {
            this.playlistaTableAdapter1.Fill(this.playlistyBinding.Playlista);
        }

        void OdswiezUtwory()
        {
            this.utworyTableAdapter1.Fill(this.databaseDataSet3.Utwory);
        }

        private void wyszukiwarkaPlaylista_TextChanged(object sender, EventArgs e)
        {
            playlistaBindingSource1.Filter = "Nazwa like '*" + wyszukiwarkaPlaylista.Text + "*'";
        }

        private void dodajUtworButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog wyborPlikow = new OpenFileDialog();
            wyborPlikow.Multiselect = true;
            wyborPlikow.Filter = "MP3|*.mp3";
            wyborPlikow.ShowDialog();
            Utwor utwor;
            string[] wybranePliki;
            wybranePliki = wyborPlikow.FileNames;

            foreach (var item in wybranePliki)
            {
                utwor = new Utwor();
                utwor.Sciezka = item;
                utwor.IdPlaylisty = (int)dataGridPlaylisty.Rows[dataGridPlaylisty.CurrentRow.Index].Cells[0].Value;
                utwor.Tytul = Path.GetFileNameWithoutExtension(item);
                baza.DodajDoPlaylisty(utwor);
            }

            OdswiezUtwory();
        }

        private void wyszukiwarkaUtwor_TextChanged(object sender, EventArgs e)
        {
            utworyBindingSource1.Filter = "Tytul like '*" + wyszukiwarkaUtwor.Text + "*'";
        }

        private void dataGridUtwory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MessageBox.Show(dataGridUtwory.Rows[e.RowIndex].Cells[2].Value.ToString());
            player.URL = dataGridUtwory.Rows[e.RowIndex].Cells[2].Value.ToString().Replace(@"\\", @"\");
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(player.URL)) ;
            {
                player.controls.play();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void pauzaButton_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }
    }
}
