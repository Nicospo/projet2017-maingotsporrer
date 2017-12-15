using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Account
    {
        public virtual double Id { get; set; }
        public virtual string Password { get; set; }
        public virtual double Passwordstrength { get; set; }
        public virtual string Name { get; set; }
        public virtual double UserId { get; set; }
        public virtual string Login { get; set; }

        public bool verificateurMdp(string password)
        {
            return password == Password;
        }

        public void modiferMdp(string password)
        {

        }

    }
}
