using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Webkit;
using AndroidX.AppCompat.App;
using Google.Android.Material.BottomNavigation;
using csharp_lang_documentation.Fragments;
using AndroidX.CardView.Widget;

namespace csharp_lang_documentation
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        TextView textMessage;
        FragmentHome fragmentHome;
        FragmentBlogs fragmentBlogs;
        FragmentAbout fragmentAbout;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            fragmentHome = new FragmentHome();
            fragmentBlogs = new FragmentBlogs();
            fragmentAbout = new FragmentAbout();

            FragmentManager.BeginTransaction().Replace(Resource.Id.fragment, fragmentHome).Commit();
            
            BottomNavigationView navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            navigation.SetOnNavigationItemSelectedListener(this);


            
            //hodisalar:
           

        }
        
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        public bool OnNavigationItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.navigation_home:
                    FragmentManager.BeginTransaction().Replace(Resource.Id.fragment, fragmentHome).Commit();
                    return true;
                case Resource.Id.navigation_blogs:
                    //Toast.MakeText(ApplicationContext, "blogs bosildi", ToastLength.Long).Show();
                    FragmentManager.BeginTransaction().Replace(Resource.Id.fragment, fragmentBlogs).Commit();
                    return true;
                case Resource.Id.navigation_about:
                    FragmentManager.BeginTransaction().Replace(Resource.Id.fragment, fragmentAbout).Commit();
                    return true;
            }
            return false;
        }
        public override void OnBackPressed()
        {
            Android.App.AlertDialog.Builder alert = new Android.App.AlertDialog.Builder(this);
            alert.SetTitle("Chiqish...");
            alert.SetMessage("Haqiqatdanham chiqmoqchimisiz?");
            alert.SetPositiveButton("Ha", (senderAlert, args) => {
                //Toast.MakeText(this, dialogPositiveBtnLabel + "!", ToastLength.Short).Show();
                //tcs.SetResult("ok");
                base.OnBackPressed();
            });
            alert.SetNegativeButton("Yoq", (senderAlert, args) => {
                //Toast.MakeText(this, dialogNegativeBtnLabel + "!", ToastLength.Short).Show();
                //tcs.SetResult(dialogNegativeBtnLabel);
            });
            Dialog dialog = alert.Create();
            dialog.Show();
            
        }
    }
}

