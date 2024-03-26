using Marathon.Models;
using Newtonsoft.Json;

namespace Marathon;

public partial class MainPage : ContentPage
{
	RaceCollection RaceObject;

	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		FillPicker();
	}

	private void FillPicker()
	{
		var client = new HttpClient();
		client.BaseAddress = new Uri("https://joewetzel.com/fvtc/marathon/");
		var response = client.GetAsync("races/").Result;
		//Get response back from the http address with the races/ at the end

		var wsJson = response.Content.ReadAsStringAsync().Result;
		//gets the json file from the response result from the link

		RaceObject = JsonConvert.DeserializeObject<RaceCollection>(wsJson);
		//Convert the JSON file and deserialize the object from the Race Collection from the wsJason content

		RacePicker.ItemsSource = RaceObject.races;
	}

    void RacePicker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
    {
		var SelectedRace = ((Picker)sender).SelectedIndex;
		//Selected item from the picker
		var race_id = RaceObject.races[SelectedRace].id;
        //get the id from the race that was selected

        var client = new HttpClient();
        client.BaseAddress = new Uri("https://joewetzel.com/fvtc/marathon/");
        var response = client.GetAsync("results/" + race_id).Result;
        //Get response back from the http address with the results and id at the end
        var wsJson = response.Content.ReadAsStringAsync().Result;

		var ResultObject = JsonConvert.DeserializeObject<ResultsCollection>(wsJson);

		var CellTemplate = new DataTemplate(typeof(TextCell));
		CellTemplate.SetBinding(TextCell.TextProperty, "name");
		CellTemplate.SetBinding(TextCell.DetailProperty, "detail");
		//Binding the values and details to the cells text

		lstResults.ItemTemplate = CellTemplate;

		lstResults.ItemsSource = ResultObject.results;

    }
}


