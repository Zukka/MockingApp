using MockingApp.Services;
using MockingApp.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MockingApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            BindingContext = new LoginPageViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}