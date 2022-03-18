
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questRootInstance : questPhaseInstance
	{
		public questRootInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
