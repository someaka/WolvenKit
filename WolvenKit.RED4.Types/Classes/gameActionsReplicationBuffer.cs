
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameActionsReplicationBuffer : RedBaseClass
	{
		public gameActionsReplicationBuffer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
