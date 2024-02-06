using DateNight.Models;

namespace DateNight;

public partial class App : Application
{
	public static DateCalculator dateCalc;
	//every page can reference this class variable

	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
		dateCalc = new DateCalculator();
		//new instance of class to use 
	}
}

