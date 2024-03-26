using System;
namespace Marathon.Models
{
	public class RaceCollection
	{
		public race[] races { get; set; }
		//get race collection array from the race class 
	}

	public class race
	{
		public int id { get; set; }
		public string race_name { get; set; }

	}
}

