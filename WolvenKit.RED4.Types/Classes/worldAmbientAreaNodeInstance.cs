
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldAmbientAreaNodeInstance : worldTriggerAreaNodeInstance
	{
		public worldAmbientAreaNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
