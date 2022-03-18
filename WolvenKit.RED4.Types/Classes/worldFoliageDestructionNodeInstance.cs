
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldFoliageDestructionNodeInstance : worldCollisionNodeInstance
	{
		public worldFoliageDestructionNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
