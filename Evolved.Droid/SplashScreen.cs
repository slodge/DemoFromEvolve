using Android.App;
using Cirrious.MvvmCross.Droid.Views;

namespace Evolved.Droid
{
    [Activity(Label = "Evolved", MainLauncher = true, Icon = "@drawable/icon")]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}