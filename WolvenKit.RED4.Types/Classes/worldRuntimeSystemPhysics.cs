
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemPhysics : worldIRuntimeSystem
	{
		public worldRuntimeSystemPhysics()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
