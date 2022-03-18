
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EndGracePeriodAfterSpawn : redEvent
	{
		public EndGracePeriodAfterSpawn()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
