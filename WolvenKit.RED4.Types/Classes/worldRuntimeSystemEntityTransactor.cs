
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemEntityTransactor : worldIRuntimeSystem
	{
		public worldRuntimeSystemEntityTransactor()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
