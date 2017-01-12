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
    public partial class oknoLogowania : Form
    {
        oknoRejestracji _oknoRejestracji;
        BazaDanych baza = new BazaDanych();
        int idUzytkownika;
        public int IdUzytkownika
        {
            get
            {
                return idUzytkownika;
            }
        }
        
        public oknoLogowania()
        {
            InitializeComponent();
        }

        private void zalogujButton_Click(object sender, EventArgs e)
        {
            idUzytkownika = baza.Zaloguj(loginLogTextBox.Text,hasloLogTextBox.Text);
            if (idUzytkownika != -1)
            {
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Niepoprawny login lub hasło");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _oknoRejestracji = new oknoRejestracji();
            _oknoRejestracji.ShowDialog();
        }
    }
}
