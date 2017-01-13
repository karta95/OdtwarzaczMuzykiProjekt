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
    public partial class oknoEdycji : Form
    {
        BazaDanych baza = new BazaDanych();
        Uzytkownik uzytkownik;
        
        public oknoEdycji()
        {
            InitializeComponent();
            //zapiszZmianyButton.BackColor = Color.WhiteSmoke;
        }

        private void zapiszZmianyButton_Click(object sender, EventArgs e)
        {
            uzytkownik = new Uzytkownik();
            uzytkownik.Login = nowaNazwaProfilu.Text;
            uzytkownik.Haslo = hasloEdycjaTextBox.Text;
            uzytkownik.Email = nowyEmailProfilu.Text;
            baza.UtworzKonto(uzytkownik);
            MessageBox.Show("Stworzono profil o nazwie: " + uzytkownik.Login);
        }
    }
}
