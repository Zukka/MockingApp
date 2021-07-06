using MockingApp.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MockingApp.ViewModels
{
    public class DogsPageViewModel : BasePageViewModel
    {
        public ICommand GetDogsCommand { get; set; }
        public ObservableCollection<Dog> Dogs { get; set; }
        public DogsPageViewModel()
        {
            GetDogsCommand = new Command(async () => await GetDogs());
            GetDogsCommand.Execute(null);
        }

        async Task GetDogs()
        {
            IsBusy = true;
            var dogs = await Api.GetDogs();
            if (dogs != null)
            {
                Dogs = new ObservableCollection<Dog>(dogs);
            }

            IsBusy = false;
        }
    }
}
