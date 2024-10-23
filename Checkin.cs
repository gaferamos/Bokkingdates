using System;
namespace Bokkingdates
{
	public class Checkin
	{
		public static void Validatecheckin(DateTime userdate, DateTime date)
		{
			if (userdate.Date == date)
			{
				Console.WriteLine($"plese in");


			}
		}
	}
}
