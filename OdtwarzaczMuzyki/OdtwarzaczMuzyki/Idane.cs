using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdtwarzaczMuzyki
{
    interface Idane
    {
        void UtworzPlayliste(string nazwa);
        void DodajDoPlaylisty(int idListy, List<string> listaUtworow);
        void UsunZPlaylisty(int idListy, List<Utwor> listaUtworow);
        List<string> PobierzPlaylisty(int idUzytkownika);
        List<Utwor> PobierzUtworyZPlaylisty(int idPlaylist);
        void UsunPlayliste(int idPlaylisty);
    }
}
