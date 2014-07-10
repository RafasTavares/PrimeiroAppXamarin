using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using SharedApp;

namespace AndroidApp.classes
{
    [Activity(Label = "AndroidApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    { 
       
        SharedMainActivity AtivShared = new SharedMainActivity();

        protected override void OnCreate(Bundle bundle)
        {
            
            base.OnCreate(bundle);
            // seta o layout que será usado
            SetContentView(Resource.Layout.Main);
            // pega o botão do layout
            Button buttonContador = FindViewById<Button>(Resource.Id.MyButton);
            buttonContador.Click += delegate { buttonContador.Text = string.Format("{0} clicks!", AtivShared.AumentarValor()); };

            Button buttonLink = FindViewById<Button>(Resource.Id.Link);

            buttonLink.Click += delegate { };
        }
    }
}

