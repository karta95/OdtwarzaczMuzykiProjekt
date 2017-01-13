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
        int idUzytkownika;
        Uzytkownik uzytkownikObecny;

        public oknoEdycji(int idUzytkownika)
        {
            InitializeComponent();
            this.idUzytkownika = idUzytkownika;
            uzytkownikObecny = baza.ZwrocUzytkownikaZBazy(idUzytkownika);
            nowaNazwaProfilu.Text = uzytkownikObecny.Login;
            hasloEdycjaTextBox.Text = uzytkownikObecny.Haslo;
            nowyEmailProfilu.Text = uzytkownikObecny.Email;
        }

        private void zapiszZmianyButton_Click(object sender, EventArgs e)
        {
            
          

            if (baza.SprawdzCzyIstnieje(nowaNazwaProfilu.Text) == false || nowaNazwaProfilu.Text == uzytkownikObecny.Login)
            {
                uzytkownikObecny.Login = nowaNazwaProfilu.Text;
                uzytkownikObecny.Haslo = hasloEdycjaTextBox.Text;
                uzytkownikObecny.Email = nowyEmailProfilu.Text;
                if (uzytkownikObecny.IsValid)
                {
                    baza.EdytujKonto(idUzytkownika, uzytkownikObecny.Login, uzytkownikObecny.Haslo, uzytkownikObecny.Email);
                    MessageBox.Show("Profil zedytowany, nowa nazwa to: " +uzytkownikObecny.Login);
                     this.Visible = false;

                }
                else
                {
                    MessageBox.Show("Nie wypełniono wszystkich pól, lub występują niepoprawne znaki");

                }
            }
            else
            {
                MessageBox.Show("Istnieje już profil o nazwie: " + nowaNazwaProfilu.Text);

            }
        }
    }
}
