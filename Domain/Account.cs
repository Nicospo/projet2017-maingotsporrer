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
        public virtual DateTime Update { get; set; }

        public bool verificateurMdp(string password)
        {
            return password == Password;
        }

        public void modiferMdp(string password)
        {

        }
        public int checkStrength(string password)
        {
            int somme;
            int nbchar=0;

            somme = password.Length*5;

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
        public override string ToString()
        {
            return "Id : " + this.Id +"\nName : " +this.Name+ "\nLogin : " + this.Login + "\nPassword : " + this.Password+"\nDate :"+Update+"\nUser ID : "+UserId ;
        }
    }
}


