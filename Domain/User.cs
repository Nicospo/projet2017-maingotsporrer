using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class User
    {
        string _login;
        string _password;
        double _passwordstrength;
        double _id;
        List<Account> _accounts;
    }


}
