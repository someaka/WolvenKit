
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisableTimeCallbacks : redEvent
	{
		public DisableTimeCallbacks()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
