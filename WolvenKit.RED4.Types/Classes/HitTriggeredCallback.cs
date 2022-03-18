
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitTriggeredCallback : HitCallback
	{
		public HitTriggeredCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
