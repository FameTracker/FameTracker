using FameTracker.Core.Layout;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace FameTracker
{
    public partial class App
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainView())
            {
                BarBackgroundColor = Color.FromHex("#303030"),
                BarTextColor = Color.White
            };
        }
    }
}