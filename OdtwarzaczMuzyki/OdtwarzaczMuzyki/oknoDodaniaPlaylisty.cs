using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace OdtwarzaczMuzyki
{
    public partial class oknoDodaniaPlaylisty : Form
    {
        BazaDanych baza = new BazaDanych();
        int idUzytkownika;
        public oknoDodaniaPlaylisty(int idUzytkownika)
        {
            InitializeComponent();
            this.idUzytkownika = idUzytkownika;
        }

        private void dodajPlaylisteButton_Click(object sender, EventArgs e)
        {
            if (nowaPlaylistaTextBox.Text == "")
            {
                MessageBox.Show("Proszę wpisać nazwę playlisty!");
            }
            else
            {
                baza.UtworzPlayliste(nowaPlaylistaTextBox.Text, idUzytkownika);

                this.Close();
            }
            
            
            
            
            
            //string connectionString = ConfigurationManager.ConnectionStrings["OdtwarzaczMuzyki.Properties.Settings.DatabaseConnectionString"].ConnectionString;

            //var query = "INSERT INTO Playlista Values (@Nazwa)";
            //using (SqlConnection conn = new SqlConnection(connectionString))   
            //using (SqlCommand command = new SqlCommand(query, conn))
            //    {
            //        conn.Open();
            //        command.Parameters.AddWithValue("@Nazwa", nowaPlaylistaTextBox.Text);
            //        command.ExecuteNonQuery();
            //        conn.Close();
            //    }
        }
    }
 }
