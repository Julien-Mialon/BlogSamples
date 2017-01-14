namespace LocalizationApp.Core
{
	public static class Helper
	{
		public static ILocalizationService Localization { get; set; }

		static Helper()
		{
			LocalizedStrings.Initialize(() => Localization);
		}
	}
}
