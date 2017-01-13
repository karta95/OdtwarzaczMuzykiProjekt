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
        int Zaloguj(string login, string haslo);
        void Wyloguj(Uzytkownik uzytkownik);
        //void ZresetujHasło(Uzytkownik uzytkownik);
        void EdytujKonto(int idUzytkownika, string nowyLogin, string noweHaslo, string nowyEmail);
    }
}
