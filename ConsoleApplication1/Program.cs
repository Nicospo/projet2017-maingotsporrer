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
          
            IUserRepository userRepo = new UserRepository();

            Console.WriteLine("Test :");
            User user1 = new User("coucou", "bite", 4);
            Console.WriteLine(user1.checkStrength(user1.Password));
            Console.ReadKey();
        }
    }
}
