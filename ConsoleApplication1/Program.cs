using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Domain;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liste des utilisateurs :");
            IUserRepository userRepo = new UserRepository();
            IList<User> users = userRepo.GetAll();
            foreach (User user in users)
            {
                Console.WriteLine(user);
            }

            Console.WriteLine("Test :");
            User user1 = userRepo.Get(3);
            Console.WriteLine(user1);
            Console.ReadKey();
        }
    }
}
