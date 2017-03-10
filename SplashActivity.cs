﻿using Android.App;
using Android.OS;
using AndroidCustomGridView;

namespace XF_SplashScreen.Droid
{
    [Activity(Theme = "@style/Theme.Splash",
        MainLauncher = true,
        NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            System.Threading.Thread.Sleep(2500);
            StartActivity(typeof(MainActivity));
        }
    }
}