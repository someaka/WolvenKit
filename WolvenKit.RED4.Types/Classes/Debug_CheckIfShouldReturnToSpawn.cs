
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Debug_CheckIfShouldReturnToSpawn : AIDebugConditions
	{
		public Debug_CheckIfShouldReturnToSpawn()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
