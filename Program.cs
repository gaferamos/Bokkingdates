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
           
            Menu.Menuoptions();

           

        }
    }
}
