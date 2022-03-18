
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldInteriorAreaNode : worldTriggerAreaNode
	{
		public worldInteriorAreaNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
