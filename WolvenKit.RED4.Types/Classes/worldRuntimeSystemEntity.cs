
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemEntity : worldIRuntimeSystem
	{
		public worldRuntimeSystemEntity()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
