
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitIsBodyPartHeadPrereq : GenericHitPrereq
	{
		public HitIsBodyPartHeadPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
