using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlarmTech.Droid
{
    [Activity(Label = "AlarmTech", Theme = "@style/splashTheme", MainLauncher = true, NoHistory = true, ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize)]
    public class Splash_Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            System.Threading.Thread.Sleep(100);
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
            // Create your application here
        }
    }
}