using Prism.Mvvm;
using Prism.Windows;
using PrismApp1.ViewModels;
using PrismApp1.Views;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;

namespace PrismApp1
{
    public partial class App : PrismApplication
    {
        public App() : base()
        {
            InitializeComponent();
        }

        protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
        {
            NavigationService.Navigate("Main", null);
            return Task.FromResult<object>(null);
        }

        protected override Task OnInitializeAsync(IActivatedEventArgs args)
        {
            ViewModelLocationProvider.Register(typeof(MainPage).ToString(), () => new MainPageViewModel(NavigationService));
            ViewModelLocationProvider.Register(typeof(UserInputPage).ToString(), () => new UserInputPageViewModel(NavigationService));

            return base.OnInitializeAsync(args);
        }
    }
}