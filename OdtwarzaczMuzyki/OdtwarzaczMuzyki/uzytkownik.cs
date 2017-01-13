using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OdtwarzaczMuzyki
{
    class Uzytkownik
    {
         string login;
         string haslo;
         string email;


        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Haslo
        {
            get { return haslo; }
            set { haslo = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public bool IsValid
        {
            get
            {
               // var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

              var regexItem = new Regex(@"^[a-z,A-Z,0-9, ą,ć,ę,ł,ń,ó,ś,ź,ż,Ą,Ć,Ę,Ł,Ń,Ó,Ś,Ź,Ż,.,-,!,@,#]*$");


            var regexEmail = new Regex(@"^[a-z0-9\._%-]+@[a-z0-9\.-]+\.[a-z]{2,4}$");

                var isSthMissed =
                    string.IsNullOrEmpty(login)
                    || string.IsNullOrEmpty(haslo)
                    || string.IsNullOrEmpty(email)
                    || (regexItem.IsMatch(login) == false)
                    || (regexItem.IsMatch(haslo) == false)
                    || (regexEmail.IsMatch(email) == false);

                if (isSthMissed)
                    return false;

                return true;
            }

            

        }

    }
}
