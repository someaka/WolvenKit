
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemEffects : worldIRuntimeSystem
	{
		public worldRuntimeSystemEffects()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
