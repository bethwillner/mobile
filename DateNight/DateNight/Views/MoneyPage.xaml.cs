namespace DateNight.Views;

public partial class MoneyPage : ContentPage
{
	public MoneyPage()
	{
		InitializeComponent();
        Title = "Total Cost of Date";
    }

    protected override void OnAppearing()
        //when appearing on page
    {
        base.OnAppearing();
        try
        {
            lblDisplay.Text = App.dateCalc.GetTotalCost();
            //display cost
        }
        catch(Exception ex)
        {
            lblDisplay.Text = "0.00";
            DisplayAlert("Error", ex.Message, "Ok");
            //display the alert saying error as title, show message that we created and display button for ok
        }

    }
}
