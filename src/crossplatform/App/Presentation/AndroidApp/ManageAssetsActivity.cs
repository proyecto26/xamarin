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
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace AndroidApp
{
    [Activity(Label = "@string/ManageAssets")]
    public class ManageAssetsActivity : AppCompatActivity
    {
        Button loadAssetButton;
        TextView assetText;
        Android.Content.Res.AssetManager manager;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ManageAssets);
            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            manager = this.Assets;
            assetText = FindViewById<TextView>(Resource.Id.assetText);
            loadAssetButton = FindViewById<Button>(Resource.Id.loadAssetButton);
            loadAssetButton.Click += LoadAssetButton_Click;
        }

        private void LoadAssetButton_Click(object sender, EventArgs e)
        {
            using (var reader = new System.IO.StreamReader(manager.Open("demo.txt")))
            {
                assetText.Text = reader.ReadToEnd();
            }
        }
    }
}