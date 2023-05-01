
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.IdentityModel.Tokens;
using System.Security.Claims;
using ApptentiveSDK;

namespace ApptentiveSample
{
    [Activity(Label = "LoginActivity")]
    public class LoginActivity : Activity
    {
        //    protected override void OnCreate(Bundle savedInstanceState)
        //    {
        //        base.OnCreate(savedInstanceState);

        //        // Create your application here
        //        SetContentView(Resource.Layout.Login);

        //        // Controls
        //        var loginButton = FindViewById<Button>(Resource.Id.loginButton);
        //        loginButton.Click += delegate {
        //            LoginUser();
        //        };

        //        var logoutButton = FindViewById<Button>(Resource.Id.logoutButton);
        //        logoutButton.Click += delegate {
        //            LogoutUser();
        //        };
        //    }

        //    private void LoginUser()
        //    {
        //        var jwt = FindViewById<TextView>(Resource.Id.jwtField).Text;
        //        Apptentive.Login(jwt, (success, error) => {
        //            if (success) {
        //                Toast.MakeText(this, "Logged In", ToastLength.Long).Show();
        //            } else {
        //                Toast.MakeText(this, "Error logging in: " + error, ToastLength.Long).Show();
        //            }
        //        });
        //    }

        //    private void LogoutUser()
        //    {
        //        Apptentive.Logout();
        //        Toast.MakeText(this, "Logged Out", ToastLength.Long).Show(); // FIXME: implement logout
        //    }
        //}
    }
}
