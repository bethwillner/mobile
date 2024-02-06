namespace BreakTime;

public partial class MainPage : ContentPage
{
    int MyTake;
    IDispatcherTimer MyTimer;
    int MyTicks, MyMinutes;
    bool isTimeUp, isOn;

	public MainPage()
	{
		InitializeComponent();
        MyTimer = Dispatcher.CreateTimer();
        MyTimer.Interval = TimeSpan.FromSeconds(1);
        MyTimer.Tick += MyTimer_Tick;
        isTimeUp = false;
	}

    private void MyTimer_Tick(object sender, EventArgs e)
    {
        if (isTimeUp == false)
        {


            MyTicks++;
            if (MyTicks == 60)
            {
                MyTicks = 0;
                MyMinutes++;

                if ((MyTake - MyMinutes) == 0)
                {
                    lblDisplay.Text = "Times Up!";
                    isTimeUp = true;
                    
                }
            }
            lblDisplay.Text = (MyTake - MyMinutes).ToString() + " Minutes Left";
        }

        else
        {
            if(isOn)
            {
                isOn = false;
                frm.Background = Colors.Red;
            }
            else
            {
                isOn = true;
                frm.Background = Colors.White;
            }
        }
    }

    void Take5_Clicked(System.Object sender, System.EventArgs e)
    {
        MyTake = 1;
        MyTimer.Start();
    }

    void Take10_Clicked(System.Object sender, System.EventArgs e)
    {
        MyTake = 10;
        MyTimer.Start();
    }

    void Take15_Clicked(System.Object sender, System.EventArgs e)
    {
        MyTake = 15;
        MyTimer.Start();
    }

    void Reset_Clicked(System.Object sender, System.EventArgs e)
    {
        MyTake = 0;
        MyTicks = 0;
        MyMinutes = 0;
        MyTimer.Stop();
        lblDisplay.Text = "Start Break Time";
        frm.Background = Colors.White;
        
    }
}


