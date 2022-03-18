
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CancelSmartDespawnRequest : redEvent
	{
		public CancelSmartDespawnRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
