using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdtwarzaczMuzyki
{
    public partial class glowne : Form
    {
        oknoEdycji _oknoEdycji;
        oknoPobierania _oknoPobierania;
        oknoLogowania _oknoLogowania;
        oknoDodaniaPlaylisty _oknoDodaniaPlaylisty;
        BazaDanych baza = new BazaDanych();
        public glowne()
        {
            InitializeComponent();
            OdswiezPlaylisty();
        }

        private void main_Load(object sender, EventArgs e)
        {
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
            string nazwa;
            if (dataGridPlaylisty.CurrentRow.Index >= 0)
            {
                nazwa = dataGridPlaylisty.Rows[dataGridPlaylisty.CurrentRow.Index].Cells[0].Value.ToString();
                baza.UsunPlayliste(nazwa, 3);
            }
            OdswiezPlaylisty();
        }

        void OdswiezPlaylisty()
        {
            //dataGridPlaylisty.Rows.Clear(); 
            //List<string> listaPlaylist = baza.PobierzPlaylisty(3);

            //for (int i = 0; i < listaPlaylist.Count; i++)
            //{
            //    dataGridPlaylisty.Rows.Insert(i, listaPlaylist[i]);
            //}
        }

        private void wyszukiwarkaPlaylista_TextChanged(object sender, EventArgs e)
        {
           //(dataGridPlaylisty.DataSource as DataTable).DefaultView.RowFilter = string.Format("Column1 LIKE '%{0}%'", wyszukiwarkaPlaylista.Text);
        }
    }
}
