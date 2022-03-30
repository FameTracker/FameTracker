using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;

namespace FameTracker.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
            // Set the default appearance values
            UIButton.Appearance.TintColor = UIColor.FromRGB(240, 240, 240);
            UIButton.Appearance.SetTitleColor(UIColor.FromRGB(48, 48, 48), UIControlState.Normal);

            UISlider.Appearance.TintColor = UIColor.Red;
        }
    }
}