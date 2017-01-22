using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using OdtwarzaczMuzyki.Properties;
using System.Windows.Forms;

namespace OdtwarzaczMuzyki
{
    class BazaDanych : Idane, Ilogowanie
    {
        string connectionString = ConfigurationManager.ConnectionStrings["OdtwarzaczMuzyki.Properties.Settings.DatabaseConnectionString"].ConnectionString;
        string path = Application.StartupPath;
        public void UtworzPlayliste(string nazwa, int userid)
        {
            //var query = "INSERT INTO Playlista(Nazwa,IdUzytkownika) VALUES(@nazwa, @userid)";
            //var query = "Instert Playlista(Nazwa,IdUzytkownika) Values(@nazwa, @userid)";
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "INSERT INTO Playlista(Nazwa,IdUzytkownika) VALUES(@nazwa, @userid)";

                using (var comm = new SqlCommand(query))
                {
                    comm.Connection = connection;
                    connection.Open();
                    comm.Parameters.AddWithValue("@nazwa", nazwa);
                    comm.Parameters.AddWithValue("@userid", userid);
                    comm.ExecuteNonQuery();
                    //var dr = comm.ExecuteReader();
                    //if (dr.Read())
                    //{
                    //    var a = dr["Login"].ToString();

                    //}
                    connection.Close();
                }
            }
        }

        public void DodajDoPlaylisty(Utwor utwor)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "INSERT INTO Utwory(Tytul,Sciezka,IdPlaylisty) VALUES(@tytul, @sciezka,@idplaylisty)";

                using (var comm = new SqlCommand(query))
                {
                    comm.Connection = connection;
                    connection.Open();
                    comm.Parameters.AddWithValue("@tytul", utwor.Tytul);
                    comm.Parameters.AddWithValue("@sciezka", utwor.Sciezka);
                    comm.Parameters.AddWithValue("@idplaylisty", utwor.IdPlaylisty);
                    comm.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void UsunUtworZPlaylisty(int idUtworu)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "DELETE FROM Utwory Where IdUtwor = @id";

                using (var comm = new SqlCommand(query))
                {
                    comm.Connection = connection;
                    connection.Open();
                    comm.Parameters.AddWithValue("@id", idUtworu);
                    comm.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public List<string> PobierzPlaylisty(int idUzytkownika)
        {
            List<string> listaPlaylist = new List<string>();
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "SELECT * FROM Playlista WHERE IdUzytkownika = @idUzytkownika";

                using (var comm = new SqlCommand(query))
                {
                    comm.Connection = connection;
                    connection.Open();
                    comm.Parameters.AddWithValue("@idUzytkownika", idUzytkownika);
                    var dr = comm.ExecuteReader();
                    while (dr.Read())
                    {
                        var piosenka = dr["Nazwa"].ToString();
                        listaPlaylist.Add(piosenka);

                    }
                    connection.Close();
                }
                return listaPlaylist;
            }

        }

        public List<Utwor> PobierzUtworyZPlaylisty(int idPlaylist)
        {
            List<Utwor> lista = new List<Utwor>();
            return lista;
        }

        public void UsunPlayliste(int idPlaylisty)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "DELETE FROM Playlista Where IdPlaylista = @id";

                using (var comm = new SqlCommand(query))
                {
                    comm.Connection = connection;
                    connection.Open();
                    comm.Parameters.AddWithValue("@id", idPlaylisty);
                    comm.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public int Zaloguj(string login, string haslo)
        {
            int id = -1;

            using (var connection = new SqlConnection(connectionString))
            {
                var query = "SELECT idUzytkownika FROM Uzytkownicy WHERE Login = @login AND Haslo =@haslo";

                using (var comm = new SqlCommand(query))
                {
                    comm.Connection = connection;
                    connection.Open();
                    comm.Parameters.AddWithValue("@login", login);
                    comm.Parameters.AddWithValue("@haslo", haslo);
                    var odczytane = comm.ExecuteScalar();
                    if (odczytane != null)
                    {
                        id = (int)odczytane;

                    }
                    connection.Close();
                }
            }
            return id;

        }

        public void Wyloguj(Uzytkownik uzytkownik)
        {
            throw new NotImplementedException();
        }

        public void UtworzKonto(Uzytkownik uzytkownik)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                var query = "INSERT INTO Uzytkownicy(Login,Haslo,Email) VALUES(@login, @haslo,@email)";

                using (var comm = new SqlCommand(query))
                {
                    comm.Connection = connection;
                    connection.Open();
                    comm.Parameters.AddWithValue("@login", uzytkownik.Login);
                    comm.Parameters.AddWithValue("@haslo", uzytkownik.Haslo);
                    comm.Parameters.AddWithValue("@email", uzytkownik.Email);
                    comm.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public bool SprawdzCzyIstnieje(string loginUzytkownika)
        {
            bool czyIstnieje = false;
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "SELECT Login FROM Uzytkownicy WHERE Login = @login";

                using (var comm = new SqlCommand(query))
                {
                    comm.Connection = connection;
                    connection.Open();
                    comm.Parameters.AddWithValue("@login", loginUzytkownika);
                    var odczytane = comm.ExecuteScalar();
                    if (odczytane != null)
                    {
                        czyIstnieje = true;

                    }
                    connection.Close();
                }
            }
            return czyIstnieje;

        }

        public void EdytujKonto(int idUzytkownika, string nowyLogin, string noweHaslo, string nowyEmail)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "UPDATE Uzytkownicy SET Login =@login ,Haslo =@haslo ,Email = @email WHERE IdUzytkownika =@id ";

                using (var comm = new SqlCommand(query))
                {
                    comm.Connection = connection;
                    connection.Open();
                    comm.Parameters.AddWithValue("@login", nowyLogin);
                    comm.Parameters.AddWithValue("@haslo", noweHaslo);
                    comm.Parameters.AddWithValue("@email", nowyEmail);
                    comm.Parameters.AddWithValue("@id", idUzytkownika);
                    comm.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public Uzytkownik ZwrocUzytkownikaZBazy(int ID)
        {
            Uzytkownik pobrany = new Uzytkownik();
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "SELECT * FROM Uzytkownicy WHERE IdUzytkownika = @idUzytkownika";

                using (var comm = new SqlCommand(query))
                {
                    comm.Connection = connection;
                    connection.Open();
                    comm.Parameters.AddWithValue("@idUzytkownika", ID);
                    var dr = comm.ExecuteReader();
                    while (dr.Read())
                    {
                        pobrany.Login = dr["Login"].ToString();
                        pobrany.Haslo = dr["Haslo"].ToString();
                        pobrany.Email = dr["Email"].ToString();
                    }
                    connection.Close();
                }
                return pobrany;
            }
        }
    }
        
    
}
