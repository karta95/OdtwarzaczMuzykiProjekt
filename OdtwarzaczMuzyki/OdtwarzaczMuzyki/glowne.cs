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
        public int IdUzytkownika
        {
            get
            {
                return idUzytkownika;
            }
        }
        oknoEdycji _oknoEdycji;
        oknoPobierania _oknoPobierania;
        oknoLogowania _oknoLogowania;
        oknoDodaniaPlaylisty _oknoDodaniaPlaylisty;        
        BazaDanych baza = new BazaDanych();
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        int pikseleNaSekunde;
        int idUzytkownika;         

        public glowne()
        {
            _oknoLogowania = new oknoLogowania();
            _oknoLogowania.ShowDialog();
            ShowMe();
            idUzytkownika = _oknoLogowania.IdUzytkownika;
            Uzytkownik zalogowanyUzytkownik = baza.ZwrocUzytkownikaZBazy(idUzytkownika);
            nazwaProfiluLabel.Text = zalogowanyUzytkownik.Login;
            OdswiezPlaylisty();
            OdswiezUtwory();
            player.PlayStateChange += new _WMPOCXEvents_PlayStateChangeEventHandler(player_PlayStateChange);
        }
        public void ShowMe()
        {
            this.Visible = true;
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
            //dataGridPlaylisty.ClearSelection();
        }

        private void main_Resize(object sender, EventArgs e)
        {
    
        }
        private void player_PlayStateChange(int NewState)
        {
           
            if (NewState ==3 )
            {
                pikseleNaSekunde = (int)((pasekOdtwarzania.Width - suwak.Width) / player.controls.currentItem.duration);
                czasTrwania_label.Text = player.controls.currentItem.durationString;
            }

            if (NewState == 8)
            {
                dataGridUtwory.Rows[0].Selected = false;
                dataGridUtwory.Rows[3].Selected = true;
                dataGridUtwory.CurrentCell = dataGridUtwory.Rows[2].Cells[1];
                //int i = dataGridUtwory.CurrentRow.Index + 1;
                //dataGridUtwory.CurrentCell = dataGridUtwory[1, i];
                //timer1.Enabled = true;
                //player.URL = dataGridUtwory.Rows[dataGridUtwory.CurrentRow.Index].Cells[2].Value.ToString();
                //suwak.Location = new Point(0, 0);
                //czasOdtwarzania.Text = "00:00";
                
                //player.controls.play();
            }
        }
        private void mójProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  this.Visible = false;
            _oknoEdycji = new oknoEdycji(IdUzytkownika);
            _oknoEdycji.ShowDialog();
        }

        private void pobierzZYouTubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _oknoPobierania = new oknoPobierania();
            _oknoPobierania.ShowDialog();
        }

        private void logowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //_oknoLogowania = new oknoLogowania();
            //_oknoLogowania.ShowDialog();
            this.Visible = false;
            glowne noweOkno = new glowne();

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
            if (dataGridPlaylisty.CurrentRow != null)
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
            }
            OdswiezUtwory();
        }

        private void wyszukiwarkaUtwor_TextChanged(object sender, EventArgs e)
        {
            utworyBindingSource1.Filter = "Tytul like '*" + wyszukiwarkaUtwor.Text + "*'";
        }

        private void dataGridUtwory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            timer1.Enabled = true;
            player.URL = dataGridUtwory.Rows[dataGridUtwory.CurrentRow.Index].Cells[2].Value.ToString();
            suwak.Location = new Point(0, 0);
            czasOdtwarzania.Text = "00:00";
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(player.URL)) 
            {
                player.controls.play();
                timer1.Enabled = true;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            timer1.Enabled = false;
        }

        private void pauzaButton_Click(object sender, EventArgs e)
        {
            player.controls.pause();
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            czasOdtwarzania.Text = player.controls.currentPositionString;
            //suwak.Location = new Point(suwak.Location.X + pikseleNaSekunde, 0);
            suwak.Location = new Point((int)(player.controls.currentPosition * pikseleNaSekunde), 0);

        }

        private void dataGridUtwory_SelectionChanged(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
            //player.URL = dataGridUtwory.Rows[dataGridUtwory.CurrentRow.Index].Cells[2].Value.ToString();
            //suwak.Location = new Point(0, 0);
            //czasOdtwarzania.Text = "00:00";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void pasekOdtwarzania_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Location.X + suwak.Width <= pasekOdtwarzania.Width)
            {
                suwak.Location = new Point(e.Location.X, 0);
                player.controls.currentPosition = e.Location.X / pikseleNaSekunde;
            }

            
        }

        private void usunUtworButton_Click(object sender, EventArgs e)
        {
            int idUtworu;
            if (dataGridUtwory.CurrentRow != null)
            {
                idUtworu = (int)dataGridUtwory.Rows[dataGridUtwory.CurrentRow.Index].Cells[0].Value;
                baza.UsunUtworZPlaylisty(idUtworu);
            }
            OdswiezUtwory();
        }

    }
}
