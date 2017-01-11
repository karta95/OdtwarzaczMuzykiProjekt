﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using OdtwarzaczMuzyki.Properties;

namespace OdtwarzaczMuzyki
{
    class BazaDanych : Idane
    {
        string connectionString = ConfigurationManager.ConnectionStrings["OdtwarzaczMuzyki.Properties.Settings.DatabaseConnectionString"].ConnectionString;
            
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

        public  void UsunZPlaylisty(int idListy, List<Utwor> listaUtworow)
        {

        }

        public  List<string> PobierzPlaylisty(int idUzytkownika)
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

        public  List<Utwor> PobierzUtworyZPlaylisty(int idPlaylist)
        {
            List<Utwor> lista = new List<Utwor>();
            return lista;
        }

        public  void UsunPlayliste(int idPlaylisty)
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

    }
}