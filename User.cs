using System;
namespace Bokkingdates
{
	public class User
	{
		public Guid Id { get; private set; }
		public string Name { get; set; }= string.Empty;
		public int Age { get; set; }
		public int Roomnum { get; set; }
		


		public User()
		{
			Id = Guid.NewGuid();
		}

        public override string ToString()
        {
            return $"Nome: {Name}, Idade: {Age}, ID: {Id}";
        }


    }
}
