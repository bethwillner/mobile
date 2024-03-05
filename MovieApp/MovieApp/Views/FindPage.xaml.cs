namespace MovieApp.Views;

public partial class FindPage : ContentPage
{
	public FindPage()
	{
		InitializeComponent();
		Title = "List Movies";
	}

    protected override void OnAppearing()
		//when appearing......
    {
        base.OnAppearing();

		var MovieTemplate = new DataTemplate(typeof(TextCell));
		// creating a new data template and creating text cell for data to bind to and display

		MovieTemplate.SetBinding(TextCell.TextProperty, "Title");
		// The text property in the text cell is called Title for movie title

		MovieTemplate.SetBinding(TextCell.DetailProperty, "Rating");
		// Set the detail property for text cell called Rating for rating of movie

		lstMovies.ItemTemplate = MovieTemplate;
		//template of the items is from the new data template called movietemplate
		lstMovies.ItemsSource = App.MovieList;
		//get the items for the list from the Movie List app
    }
}
