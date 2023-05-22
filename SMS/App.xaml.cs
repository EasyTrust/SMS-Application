using SMS.Pages;

namespace SMS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SplashScreenPage());
        }
    }
}