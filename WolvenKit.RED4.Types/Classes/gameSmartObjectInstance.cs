
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSmartObjectInstance : RedBaseClass
	{
		public gameSmartObjectInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
