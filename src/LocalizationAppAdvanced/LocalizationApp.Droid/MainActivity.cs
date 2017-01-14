using Android.App;
using Android.Widget;
using Android.OS;

namespace LocalizationApp.Droid
{
	[Activity(Label = "LocalizationApp.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			
			SetContentView (Resource.Layout.Main);

			TextView label = FindViewById<TextView>(Resource.Id.Label);
			label.Text = LocalizedStrings.ApplicationName;
		}
	}
}

