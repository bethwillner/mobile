using System;
using SQLite;

namespace MovieApp.Models
{
	public class Movie
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		//add primary key and auto increment the ID

		public string Title { get; set; }
		public string Rating { get; set; }
        //prop *tab tab*; setting properties that get and set the strings and ints for the data
    }
}

