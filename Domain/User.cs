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

        public User(string login, string password, int id)
        {
            Login = login;
            Password = password;
            Passwordstrength = checkStrength(password);
            Id = id;
        }
        public override string ToString()
        {
            return "Id : " + this.Id + "\nLogin : " + this.Login + "\nPassword : " + this.Password;
        }

        public virtual void newPassword()
        {

        }

        public virtual int checkStrength(string password)
        {
            int somme;
            int nbchar = 0;

            somme = password.Length * 5;

            if (password.Any(c => char.IsUpper(c)))
                nbchar++;

            if (password.Any(c => char.IsLower(c)))
                nbchar++;

            if (password.Any(c => char.IsSymbol(c)))
                nbchar++;

            if (password.Any(c => char.IsNumber(c)))
                nbchar++;

            if (nbchar == 1)
                somme = (int)(somme * 0.75);
            if (nbchar == 2)
                somme = (int)(somme * 1.3);
            if (nbchar == 3)
                somme = (int)(somme * 1.7);
            if (nbchar == 4)
                somme = (int)(somme * 2);

            return somme;
        }
    }


}
