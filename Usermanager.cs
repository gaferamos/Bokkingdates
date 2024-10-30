using System;
namespace Bokkingdates
{
    public class Usermanager
    {
        private readonly List<User> users = new List<User>();
        
        public void CreateUserInput()
        {
            Console.Clear();
            Console.WriteLine("Register");
            Console.Write("Name: ");
            var name = Console.ReadLine();

            if (users.Any(u => u.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("A user with this name already exists.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return;
            }

            Console.Write("age: ");
            var age = int.Parse(Console.ReadLine());

            Console.Write("Room number: ");
            var roomnum = int.Parse(Console.ReadLine());

            User newuser = new User() { Age = age, Name = name, Roomnum = roomnum};

            users.Add(newuser);
            Console.WriteLine("Successfully registered");
            Console.Write("Use this id to login: ");
            Console.WriteLine(newuser.Id);
            Console.ReadKey();

        }

        public void UserLogin()
        {
            Console.Clear();
            Console.WriteLine("Login");

            Console.WriteLine("Name:");
            var loginname = Console.ReadLine();


            Console.WriteLine("Id:");
            var logiID = Guid.Parse(Console.ReadLine());

            foreach (var user in users)
            {
                if (user.Name.Equals(loginname) && user.Id.Equals(logiID))
                {
                    Console.WriteLine($"Wellcome, {user.Name}");
                    Console.ReadKey();
                    Menu.Menuoptions();

                }
                else 
                { Console.WriteLine("Invalid logni"); }
                return;
            }
        }

        public void Acsessmenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Register");
            Console.WriteLine("2 - Login");
            Console.WriteLine("3 - exit");
            Console.Write("select you option: ");
           short option = short.Parse(Console.ReadLine());

            switch (option) 
            {
                case 1:
                    {
                        CreateUserInput();
                        Acsessmenu();
                    }
                break;

                case 2:
                    {

                     UserLogin();

                    }
                break;

                case 3:
                    {
                        Environment.Exit(0);
                    }
                break;

                default:
                    {
                        Console.Clear();

                        Console.Write("Invalid option, pleas wait.");
                        Thread.Sleep(1500);
                        Acsessmenu();
                    }
                break;
            }
        }
    }
    
}