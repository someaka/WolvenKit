
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemEntityTransforms : worldIRuntimeSystem
	{
		public worldRuntimeSystemEntityTransforms()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
