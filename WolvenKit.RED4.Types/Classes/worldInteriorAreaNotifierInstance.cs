
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldInteriorAreaNotifierInstance : worldITriggerAreaNotiferInstance
	{
		public worldInteriorAreaNotifierInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
