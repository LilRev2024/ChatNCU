using ChatNCU.ViewModels;
namespace ChatNCU.Pages;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginPageViewModel viewModel)
    {
        InitializeComponent();

        this.BindingContext = viewModel;
    }
}