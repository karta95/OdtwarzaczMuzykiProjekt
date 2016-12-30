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

        public oknoDodaniaPlaylisty()
        {
            InitializeComponent();
        }

        private void dodajPlaylisteButton_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["OdtwarzaczMuzyki.Properties.Settings.DatabaseConnectionString"].ConnectionString;

            var query = "INSERT INTO Playlista Values (@Nazwa)";
            using (SqlConnection conn = new SqlConnection(connectionString))   
            using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.AddWithValue("@Nazwa", nowaPlaylistaTextBox.Text);
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
