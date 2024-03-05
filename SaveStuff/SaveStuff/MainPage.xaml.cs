namespace SaveStuff;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    void Save_Clicked(System.Object sender, System.EventArgs e)
    {
        Preferences.Set("UserName", txtUserName.Text);
        //Set username as key to call on, and get info from textbox user string
    }

    void Read_Clicked(System.Object sender, System.EventArgs e)
    {
        txtUserName.Text = Preferences.Get("UserName", "");
        //return string with key and if nothing is there then return a blank string
    }

    void Clear_Clicked(System.Object sender, System.EventArgs e)
    {
        txtUserName.Text = string.Empty;
    }
}


