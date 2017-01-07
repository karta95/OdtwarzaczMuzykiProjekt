using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdtwarzaczMuzyki
{
    class Utwor
    {
        string tytul;
        string sciezka;
        int idPlaylisty;

        public string Tytul
        {
            get { return tytul; }
            set { tytul = value; }
        }

        public string Sciezka
        {
            get { return sciezka; }
            set { sciezka = value; }
        }

        public int IdPlaylisty
        {
            get { return idPlaylisty; }
            set { idPlaylisty = value; }
        }
    }
}
