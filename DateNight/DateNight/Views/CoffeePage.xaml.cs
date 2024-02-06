namespace DateNight.Views;

public partial class CoffeePage : ContentPage
{
	public CoffeePage()
	{
		InitializeComponent();
		Title = "Going For Coffee";
	}

    protected override void OnDisappearing()
		//after they leave the page
    {
        base.OnDisappearing();
		//as they leave the page enter in:
		App.dateCalc.CoffeeCost = txtCoffee.Text;
		//get CoffeeCost from txtCoffee
    }


}
