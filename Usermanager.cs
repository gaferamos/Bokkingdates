using System;
namespace Bokkingdates
{
    public class Usermanager
    {
        private List<User> users = new List<User>();

        public void CreateUserInput()
        {
            Console.Clear();
            Console.Write("Register");
            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("age: ");
            var age = int.Parse(Console.ReadLine());

            Console.Write("Room number: ");
            var roomnum = int.Parse(Console.ReadLine());

            User newuser = new User() { Age = age, Name = name, Roomnum = roomnum};

            users.Add(newuser);
            Console.Write("Successfully registered");

        }
        
    }
}