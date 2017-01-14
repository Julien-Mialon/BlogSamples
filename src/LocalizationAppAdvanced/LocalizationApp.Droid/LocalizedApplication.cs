using System;
using Android.App;
using Android.Runtime;
using LocalizationApp.Core;

namespace LocalizationApp.Droid
{
	[Application]
	public class LocalizedApplication : Application
	{
		public LocalizedApplication(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		public override void OnCreate()
		{
			base.OnCreate();
			LocalizedStrings.Initialize(this);
			Helper.Localization = new LocalizationService(this);
		}
	}
}