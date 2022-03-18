
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitIsRicochetPrereq : GenericHitPrereq
	{
		public HitIsRicochetPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
