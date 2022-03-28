using Xamarin.Forms.Xaml;
using FameTracker.Features.Twitter;
using Xamarin.Forms;

namespace FameTracker.Features.Twitter
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TwitterView
    {
        public TwitterView()
        {
            InitializeComponent();

            var twitterViewModel = new TwitterViewModel();

            Tweet_1.Text = twitterViewModel.GetTweets()[0].Text;
        }
    }
}