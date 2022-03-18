
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OnFocusLost : inkFocusEvent
	{
		public OnFocusLost()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
