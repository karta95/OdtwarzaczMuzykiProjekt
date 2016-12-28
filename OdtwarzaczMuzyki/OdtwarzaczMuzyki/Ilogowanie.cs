using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdtwarzaczMuzyki
{
    interface Ilogowanie
    {
        void UtworzKonto(Uzytkownik uzytkownik);
        void Zaloguj(Uzytkownik uzytkownik);
        void Wyloguj(Uzytkownik uzytkownik);
        void ZresetujHasło(Uzytkownik uzytkownik);
        void ZmienHasło(int idUzytkownika);
    }
}
