using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FameTracker.Features.Tweets
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TweetsView : ContentPage
    {
        public TweetsView()
        {
            InitializeComponent();
        }
    }
}