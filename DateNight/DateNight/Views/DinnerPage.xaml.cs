namespace DateNight.Views;

public partial class DinnerPage : ContentPage
{
	public DinnerPage()
	{
		InitializeComponent();
		Title = "Going Out For Dinner";
	}

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
		App.dateCalc.DinnerCost = txtDinner.Text;
    }
}
