using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class User
    {
        public virtual string Login { get; set; }
        public virtual string Password { get; set; }
        public virtual double Passwordstrength { get; set; }
        public virtual int Id { get; set; }
    }


}
