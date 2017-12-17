using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        public virtual string Login { get; set; }
        public virtual string Password { get; set; }
        public virtual double Passwordstrength { get; set; }
        public virtual int Id { get; set; }

        public User()
        {}

        public User(string login, string password, double passwordStrength, int id)
        {
            Login = login;
            Password = password;
            Passwordstrength = passwordStrength;
            Id = id;
        }
        public override string ToString()
        {
            return "Id : " + this.Id + "\nLogin : " + this.Login + "\nPassword : " + this.Password;
        }
    }


}
