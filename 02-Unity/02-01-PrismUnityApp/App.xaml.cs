using Prism.Mvvm;
using Prism.Unity.Windows;
using Prism.Windows;
using PrismApp1.ViewModels;
using PrismApp1.Views;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;

namespace PrismApp1
{
    public partial class App : PrismUnityApplication
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

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
        }
    }
}