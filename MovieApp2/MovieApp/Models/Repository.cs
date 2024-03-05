using System;
using SQLite;

namespace MovieApp.Models
{
	public class Repository
	{
		private readonly SQLiteConnection _database;
		//read only database

		public Repository()
		{
			var dbpath = Path.Combine(
				Environment.GetFolderPath(
					//get the folder path from the phone
				Environment.SpecialFolder.LocalApplicationData),"movies.db");
			//find the folder of local app data and combine it with movies database

			_database = new SQLiteConnection(dbpath);
			_database.CreateTable<Movie>();
			//create table from the movie path
		}

		public List<Movie> GetMovies()
		{
			return _database.Table<Movie>().ToList();
			//creation of method and returning a table from the movie class and list it

			//return _database.Query<Movie>("select * from Movie where ID > 3");
		}

		public void SaveMovie(Movie movie)
		{
			_database.Insert(movie);
			//save movie from movie model and then insert the movie into the database
		}
	}
}

