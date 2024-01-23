namespace Roman;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    void Convert_Clicked(System.Object sender, System.EventArgs e)
    {
        int intInput;
        //declaring input 
        bool isNumber;

        Converter converter = new Converter();
      

        isNumber = Int32.TryParse(txtInput.Text, out intInput);
        //trying to take input as either a number or a letter/string

        if(isNumber)
            //if it is a number then number to roman numeral 
        {
            lblDisplay.Text = converter.NumberToRoman(intInput);
        }
        else
            // if it is a roman string then roman to number
        {
            lblDisplay.Text = converter.RomanToNumber(txtInput.Text).ToString();
        }
    }
}


