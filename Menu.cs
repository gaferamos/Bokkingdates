using System;
using System.Globalization;
namespace Bokkingdates
{

	public class Menu
	{
		public static void Menuoptions()
		{
            
			Console.Clear();
            Console.WriteLine("Select an option");
            Console.WriteLine("1 -- Reservate");
            Console.WriteLine("2 -- Check-in");
            Console.WriteLine("3 -- Check-out");
            Console.WriteLine("0 -- Close booking app");
            short option = short.Parse(Console.ReadLine());
            Ophendler(option);
        }
        public static void Ophendler(short option)
        {
            switch (option)
            {
                case 1:
                    {
                        try
                        {   
                            Console.WriteLine("Please provide the start date of your stay");
                            var userdate = DateTime.Parse(Console.ReadLine());
                            Finaldays.Adddays(userdate);
                            
                            
                            


                        }
                        catch (FormatException ex)
                        {

                            Console.WriteLine("invalid format. try inform date by ( dd / MM / yyyy )");
                            Console.WriteLine(ex.Data);

                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine(ex.InnerException);
                            Console.WriteLine(ex.Data);

                        }
                        finally
                        {
                            Console.WriteLine("Thankyou");
                        }
                    }
                    break;

                case 0:
                    {
                        System.Environment.Exit(0);
                    }
                    break;
            
            }

        }
       


    }

    
}