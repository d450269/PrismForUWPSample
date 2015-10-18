using Prism.Commands;
using Prism.Windows.AppModel;
using Prism.Windows.Mvvm;
using Prism.Windows.Navigation;

namespace PrismApp1.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private INavigationService navigationService;

        public DelegateCommand NavigateCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            NavigateCommand = new DelegateCommand(() => navigationService.Navigate("UserInput", null));
        }

        private string text;
        [RestorableState]
        public string Text
        {
            get { return text; }
            set { SetProperty(ref text, value); }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { SetProperty(ref age, value); }
        }
    }
}
