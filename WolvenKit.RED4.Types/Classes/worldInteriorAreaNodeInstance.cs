
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldInteriorAreaNodeInstance : worldTriggerAreaNodeInstance
	{
		public worldInteriorAreaNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
