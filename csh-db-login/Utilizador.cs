using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csh_db_login
{
    class Utilizador
    {
        private string user;
        private string pass;

        public Utilizador()
        {
            user = "";
            pass = "";
        }

        public Utilizador(string u, string p)
        {
            user = u;
            pass = p;
        }

        public string getUser()
        {
            return user;
        }

        public string getPass()
        {
            return pass;
        }

        public string toString()
        {
            return user + " " + pass;
        }
    }
}
