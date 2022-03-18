
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldITrafficSystem : worldIRuntimeSystem
	{
		public worldITrafficSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
