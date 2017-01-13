using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdtwarzaczMuzyki
{
    public partial class oknoRejestracji : Form
    {
        BazaDanych baza = new BazaDanych();
        Uzytkownik nowyUzytkownik;
        public oknoRejestracji()
        {
            InitializeComponent();
        }

        private void utworzProfilButton_Click(object sender, EventArgs e)
        {
            //var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

            //if (regexItem.IsMatch(nazwaProfiluTextBox.Text))
            //    MessageBox.Show("Super nazwa");
            //else
            //{
            //    MessageBox.Show("Niepoprawna nazwa");
            //}
            
            if (baza.SprawdzCzyIstnieje(nazwaProfiluTextBox.Text) == false)
            {
                nowyUzytkownik = new Uzytkownik();
                nowyUzytkownik.Login = nazwaProfiluTextBox.Text;
                nowyUzytkownik.Haslo = hasłoProfiluTextBox.Text;
                nowyUzytkownik.Email = emailProfiluTextBox.Text;
                if (nowyUzytkownik.IsValid)
                {
                    baza.UtworzKonto(nowyUzytkownik);
                    MessageBox.Show("Stworzono profil o nazwie: " + nowyUzytkownik.Login);
                }
                else
                {
                    MessageBox.Show("Nie wypełniono wszystkich pól, lub występują niepoprawne znaki");

                }
            }
            else
            {
                MessageBox.Show("Istnieje już profil o nazwie: " + nazwaProfiluTextBox.Text);

            }

        }
    }
}
