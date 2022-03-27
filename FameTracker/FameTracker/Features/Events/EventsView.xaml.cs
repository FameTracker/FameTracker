using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FameTracker.Features.Events
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventsView : ContentPage
    {
        public EventsView()
        {
            InitializeComponent();
        }
    }
}