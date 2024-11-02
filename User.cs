using System;
namespace Bokkingdates
{
	public class User
	{
		public Guid Id { get; private set; }
		public string Name { get; set; }= string.Empty;
		public int Age { get; set; }
		public int Roomnum { get; set; }
		public DateTime? Checkindate { get; set; }
        public DateTime? Checkoutdate { get; set; }



        public User()
		{
			Id = Guid.NewGuid();
		}

        public override string ToString()
        {
            return $"Nome: {Name}, Idade: {Age}, ID: {Id}";
        }
		public void AddInitialDate(DateTime userdate)
		{
            Checkindate = userdate;

        }

        public static void InputInitialDate(Usermanager usermanager, Guid logiID)
        {

            //var uai = userManager.users.FirstOrDefault(u => u.Id == logiID);

        }

    }
}
