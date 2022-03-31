using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FameTracker.Features.Twitter
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TwitterView
    {
        public TwitterView()
        {
            InitializeComponent();
            
            
            GetTweets(EntriesList);
            
            // ICommand refreshCommand = new Command(() =>
            // {
            //     GetTweets(EntriesList);
            //     RefreshView.IsRefreshing = false;
            // });
            // RefreshView.Command = refreshCommand;
        }

        private void GetTweets(CollectionView EntriesList)
        {
            TwitterService twitterService = new();
            var data = twitterService.FetchTweets().Result;
            EntriesList.ItemsSource = data;
        }
    }
}