using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FameTracker.Features.Photos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhotosView : ContentPage
    {
        public PhotosView()
        {
            InitializeComponent();
        }
    }
}