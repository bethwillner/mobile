using MovieApp.Models;
//need to add in using statement to make the connnections down below

namespace MovieApp;

public partial class App : Application
{
	//public static List<Movie> MovieList;
	//create list from the model: Movie called MovieList

	public static Repository MovieList;
	//create repository class called movie list

	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

		//MovieList = new List<Movie>();

		MovieList = new Repository();
		//movieList is a new respository 
	}
}

