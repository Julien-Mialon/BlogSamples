using System.Diagnostics;

namespace LocalizationApp.Core
{
	public class Test
	{
		public Test()
		{
			// with service
			Debug.WriteLine(Helper.Localization.Get(EnumStrings.ApplicationName));

			//with localization strings class
			Debug.WriteLine(LocalizedStrings.ApplicationName);
		}
	}
}
