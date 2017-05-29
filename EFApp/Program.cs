using EFApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserCommand= "";
            do
            {
                UserCommand = Console.ReadLine();
                


            } while (UserCommand != "q");


            using (UserContext db = new UserContext())
            {
                User user1 = new User { Name = "Tom", Age = 33 };
                User user2 = new User { Name = "Sam", Age = 26 };

                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();
                Console.WriteLine("Objects saved succes");

                var users = db.Users;
                Console.WriteLine("Object list:");
                foreach (User u in users)
                {
                    Console.WriteLine("{0}.{1} - {2}", u.Id, u.Name, u.Age);
                }
            }
            Console.WriteLine("End Users");
            using (PhoneContext db = new PhoneContext())
            {
                Phone p1 = new Phone { Name = "Samsung Galaxy S7", Price = 20000 };
                Phone p2 = new Phone { Name = "iPhone 7", Price = 28000 };
                
                db.Phones.Add(p1);
                db.Phones.Add(p2);
                db.SaveChanges();
                Console.WriteLine("Readed Phones");
                var phones = db.Phones.ToList();
                
                foreach (var p in phones)
                {
                    Console.WriteLine("{0} - {1} - {2}", p.Id, p.Name, p.Price);
                }

            }
            Console.WriteLine("End Phones");
            Console.Read();
        }
    }
}
