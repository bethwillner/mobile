namespace CustomGPS;

public partial class MainPage : ContentPage
{
	GeolocationRequest request;

	public MainPage()
	{
		InitializeComponent();
		Title = "Location Application";
		request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
		// set the accuracy for the geolocation
	}

    async void UpdateLocation_Clicked(System.Object sender, System.EventArgs e)
    {
		Location location = await Geolocation.Default.GetLocationAsync();
		//pass in request and then get the location back

		lblLat.Text = "Lat: " + location.Latitude.ToString();
		lblLon.Text = "Lon: " + location.Longitude.ToString();

        var placemarks = await Geocoding.Default.GetPlacemarksAsync(location.Latitude, location.Longitude);
        Placemark placemark = placemarks?.FirstOrDefault();


        lblAddress.Text = placemark.SubThoroughfare + " " + placemark.Thoroughfare;
        lblAddress2.Text = placemark.Locality + " " + placemark.AdminArea + "  " + placemark.PostalCode;
    }

    
}


