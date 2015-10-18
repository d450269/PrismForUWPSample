using Prism.Commands;
using Prism.Windows.Mvvm;
using Prism.Windows.Navigation;

namespace PrismApp1.ViewModels
{
    public class UserInputPageViewModel : ViewModelBase
    {
        private INavigationService navigationService;

        public DelegateCommand NavigateCommand { get; set; }

        public UserInputPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            NavigateCommand = new DelegateCommand(() => navigationService.GoBack());
        }
    }
}
