using Prism.Commands;
using Prism.Windows.AppModel;
using Prism.Windows.Mvvm;
using Prism.Windows.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

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

        private string text;
        public string Text
        {
            get { return text; }
            set { SetProperty(ref text, value); }
        }

        private int age;
        [RestorableState]
        public int Age
        {
            get { return age; }
            set { SetProperty(ref age, value); }
        }

        public override void OnNavigatingFrom(NavigatingFromEventArgs e, Dictionary<string, object> viewModelState, bool suspending)
        {
            base.OnNavigatingFrom(e, viewModelState, suspending);

            ApplicationData.Current.LocalSettings.Values["Age"] = this.age;
        }

        public override void OnNavigatedTo(NavigatedToEventArgs e, Dictionary<string, object> viewModelState)
        {
            base.OnNavigatedTo(e, viewModelState);
            this.Text = e.Parameter as string;
        }
    }
}
