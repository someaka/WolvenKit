
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DelayedRegisterToGlobalInputCallbackEvent : redEvent
	{
		public DelayedRegisterToGlobalInputCallbackEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
