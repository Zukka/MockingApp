using MockingApp.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MockingApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DogsPage : ContentPage
    {
        public DogsPage()
        {
            InitializeComponent();
            BindingContext = new DogsPageViewModel();
        }
    }
}