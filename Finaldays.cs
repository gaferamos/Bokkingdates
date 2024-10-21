using System;
namespace Bokkingdates
{
    public class Finaldays
    {
        public static void Adddays(DateTime userdate)
        {
            Console.Clear();

            Console.WriteLine($"Your initial reservation tade is: {userdate}");
            Console.WriteLine("Please provide the end date of your stay or the number of days you'd like to stay");
            var adddays = Console.ReadLine();
            
            if(int.TryParse(adddays,out int addingdays))
            {
                var finaluserdate = userdate.AddDays(addingdays);
          
                Console.WriteLine($"Final date of stayng{finaluserdate}");
            }
            else if (DateTime.TryParse(adddays,out DateTime finaluserdate))
            {
                Console.WriteLine($"Final date of stayng{finaluserdate}");

            }
        }

    }
}
