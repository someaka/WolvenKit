
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldPhysicalDestructionNodeInstance : worldSnappableNodeInstance
	{
		public worldPhysicalDestructionNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
