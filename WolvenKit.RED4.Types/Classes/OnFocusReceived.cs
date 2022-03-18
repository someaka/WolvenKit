
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OnFocusReceived : inkFocusEvent
	{
		public OnFocusReceived()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
