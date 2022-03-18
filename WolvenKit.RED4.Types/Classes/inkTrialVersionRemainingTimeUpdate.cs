
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkTrialVersionRemainingTimeUpdate : inkCallbackBase
	{
		public inkTrialVersionRemainingTimeUpdate()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
