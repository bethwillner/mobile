using MovieApp.Models;

namespace MovieApp.Views;

public partial class AddPage : ContentPage
{
	public AddPage()
	{
		InitializeComponent();
		Title = "Add New Movie";
	}

    void Add_Clicked(System.Object sender, System.EventArgs e)
    {
		var nm = new Movie();

		nm.Title = txtTitle.Text;
		nm.Rating = txtRating.Text;
		//Filling model with data from the model get and set titles and ratings

		App.MovieList.Add(nm);
		//Add nm (new Movie) to Movie List model new instance of the movie model (App.xaml.cs creation of this)

		txtTitle.Text = "";
		txtRating.Text = "";
    }
}
