
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldEnvAreaNotifierInstance : worldITriggerAreaNotiferInstance
	{
		public worldEnvAreaNotifierInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
