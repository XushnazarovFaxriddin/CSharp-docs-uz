using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Webkit;
//using System;
using Android.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using csharp_lang_documentation;
using AndroidX.CardView.Widget;

namespace csharp_lang_documentation.Fragments
{
    public class FragmentAbout : Fragment
    {
        string url;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetHasOptionsMenu(true);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);
            var view = inflater.Inflate(Resource.Layout.about, container, false);

            //Faxriddin Button Click
            view.FindViewById<CardView>(Resource.Id.card_about_founder).Click += (s, e) =>
            {
                url = "https://t.me/Xushnazarov_555";
                StartActivity(new Intent(Intent.ActionView, Uri.Parse(url)));
            };

            //SardorBek button Click
            view.FindViewById<CardView>(Resource.Id.card_about_ui).Click += delegate
            {
                url = "https://t.me/The_sardorb3k";
                StartActivity(new Intent(Intent.ActionView,Uri.Parse(url)));
            };

            //.NET button Click
            view.FindViewById<CardView>(Resource.Id.card_about_dotnet).Click += delegate
            {
                url = "https://t.me/uz_dotnet";
                StartActivity(new Intent(Intent.ActionView, Uri.Parse(url)));
            };

            //tg Upper button Click
            view.FindViewById<CardView>(Resource.Id.card_about_telegram).Click += delegate
            {
                url = "https://t.me/upper_uz";
                StartActivity(new Intent(Intent.ActionView, Uri.Parse(url)));
            };

            //insta Upper button Click
            view.FindViewById<CardView>(Resource.Id.card_about_instagram).Click += delegate
            {
                url = "https://www.instagram.com/upper.uz/";
                StartActivity(new Intent(Intent.ActionView, Uri.Parse(url)));
            };

            //github Upper button Click
            view.FindViewById<CardView>(Resource.Id.card_about_github).Click += delegate
            {
                url = "https://github.com/upper-uz";
                StartActivity(new Intent(Intent.ActionView, Uri.Parse(url)));
            };

            //web Upper button Click
            view.FindViewById<CardView>(Resource.Id.card_about_web).Click += delegate
            {
                string text = "Tez orada web saytimiz ham ishga tushadi :).";
                Toast.MakeText(Application.Context, text, ToastLength.Short).Show();
            };

            return view;
        }

    }
}