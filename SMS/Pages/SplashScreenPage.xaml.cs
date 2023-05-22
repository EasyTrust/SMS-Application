namespace SMS.Pages;

public partial class SplashScreenPage : ContentPage
{
	public SplashScreenPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await Task.Delay(3000); // Display splash screen for 3 seconds
        await Navigation.PushAsync(new MainPage()); // Navigate to the main page
    }
}