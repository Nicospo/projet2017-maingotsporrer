using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Domain;

namespace Test
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liste des utilisateurs :");
            IUserRepository userRepo = new UserRepository();
            foreach (User user in userRepo.GetAll())
            {
                Console.WriteLine(user.Login);
            }
        }
    }
}
