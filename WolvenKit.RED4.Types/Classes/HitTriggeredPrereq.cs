
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitTriggeredPrereq : GenericHitPrereq
	{
		public HitTriggeredPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
