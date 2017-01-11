using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdtwarzaczMuzyki
{
    interface Idane
    {
        void UtworzPlayliste(string nazwa, int userid);
        void DodajDoPlaylisty(Utwor utwor);
        void UsunUtworZPlaylisty(int idUtworu);
        List<string> PobierzPlaylisty(int idUzytkownika);
        List<Utwor> PobierzUtworyZPlaylisty(int idPlaylist);
        void UsunPlayliste(int idPlaylisty);
    }
}
