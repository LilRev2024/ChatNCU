using ChatNCU.Views;

namespace ChatNCU;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new HomeView());
    }
}