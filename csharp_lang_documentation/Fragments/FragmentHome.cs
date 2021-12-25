using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Android.Webkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using csharp_lang_documentation.Resources.Pages;

namespace csharp_lang_documentation.Fragments
{
    public class FragmentHome : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetHasOptionsMenu(true);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view =inflater.Inflate(Resource.Layout.home, container, false);

            view.FindViewById<Button>(Resource.Id.batafsil_Btn).Click += delegate
            {
                StartActivity(new Intent(this.Activity, typeof(WhatsIsCsharp)));
            };

            return view;
        }
    }
}