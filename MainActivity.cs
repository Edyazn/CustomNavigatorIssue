﻿using Android.App;
using Android.OS;
using AndroidX.AppCompat.App;

namespace com.companyname.CustomNavigatorIssue
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.navigation_activity);
        }
    }
}