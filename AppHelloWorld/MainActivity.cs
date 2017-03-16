using Android.App;
using Android.Widget;
using Android.OS;

namespace AppHelloWorld
{
    [Activity(Label = "AppHelloWorld", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            Button b = FindViewById<Button>(Resource.Id.btnMain);
            b.Click += B_Click;
        }

        static int count = 0;
        private void B_Click(object sender, System.EventArgs e)
        {
            TextView t = FindViewById<TextView>(Resource.Id.txtViewMain);
            count++;
            t.Text = string.Format("Hello World {0}", count);
        }
    }
}

