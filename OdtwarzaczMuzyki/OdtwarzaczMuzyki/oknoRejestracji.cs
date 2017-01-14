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
        oknoBledu _oknoBledu;

        public oknoRejestracji()
        {
            InitializeComponent();
        }

        private void utworzProfilButton_Click(object sender, EventArgs e)
        {

            if (baza.SprawdzCzyIstnieje(nazwaProfiluTextBox.Text) == false)
            {
                nowyUzytkownik = new Uzytkownik();
                nowyUzytkownik.Login = nazwaProfiluTextBox.Text;
                nowyUzytkownik.Haslo = hasłoProfiluTextBox.Text;
                nowyUzytkownik.Email = emailProfiluTextBox.Text;
                if (nowyUzytkownik.IsValid && nowyUzytkownik.IsEmpty)
                {
                    baza.UtworzKonto(nowyUzytkownik);
                    _oknoBledu = new oknoBledu("Stworzono profil o nazwie: " + nowyUzytkownik.Login);
                    this.Visible = false;

                }
                else if (nowyUzytkownik.IsValid == false)
                {
                    _oknoBledu = new oknoBledu("Niepoprawny format");
                }
                else 
                {
                    _oknoBledu = new oknoBledu("Nie wypełniono wszystkich pól");
                }
            }
            else
            {
                _oknoBledu = new oknoBledu("Istnieje już profil o nazwie: " + nazwaProfiluTextBox.Text);
            }

        }
    }
}
