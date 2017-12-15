using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Account
    {
        double _id;
        string _password;
        double _passwordstrength;
        string _name;
        string _login;

        public bool verificateurMdp(string password)
        {
            return password == _password;
        }

        public void modiferMdp(string password)
        {

        }


    }
}
