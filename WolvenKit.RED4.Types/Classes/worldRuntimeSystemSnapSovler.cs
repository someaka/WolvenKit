
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemSnapSovler : worldIRuntimeSystem
	{
		public worldRuntimeSystemSnapSovler()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
