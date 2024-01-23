namespace HelloWorld;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	void Handle_Clicked(object sender, EventArgs e)
	{

		if (lblDisplay.Text == "Hello World!")
		{
			lblDisplay.Text = "Have a Good Day";
		}
		else
		{
			lblDisplay.Text = "Hello World!";
		}
	}
}


