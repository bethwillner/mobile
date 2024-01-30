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

		if (lblDisplay.Text == "Have a Good Day!")
		{
			lblDisplay.Text = "Hello World";
		}
		else
		{
			lblDisplay.Text = "Have a Good Day!";
		}
	}
}


