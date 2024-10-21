using System.Collections.Specialized;
using System.Globalization;

namespace Bokkingdates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var date = DateTime.Now;
            Console.WriteLine(date.Date);
            Console.WriteLine("Wellcome");
            Console.WriteLine("To exit press ESC kay");
            Menu.Menuoptions();


            //var userdate = DateTime.Parse( Console.ReadLine());
            //String '10/21/2024' was not recognized as a valid DateTime.

            //System.Collections.ListDictionaryInternal
            //Console.WriteLine(userdate.Date);
            //var stayngdays = userdate.Date - date.Date;
            //Console.WriteLine(stayngdays.Days);
            //int adddays = int.Parse(Console.ReadLine());
            //var newdate = userdate.AddDays(adddays);
            //Console.WriteLine(newdate);


            //if (adddays is int)
            //{
            //    Console.WriteLine("eeeeeeeeeeeeeee ");
            //}
            //else
            //{

            //}

        }
    }
}
