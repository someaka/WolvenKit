
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitIsSourceGrenadePrereq : GenericHitPrereq
	{
		public HitIsSourceGrenadePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
