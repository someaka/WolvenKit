
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitIsBodyPartLimbPrereq : GenericHitPrereq
	{
		public HitIsBodyPartLimbPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
