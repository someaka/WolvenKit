
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitIsInstigatorPlayerPrereq : GenericHitPrereq
	{
		public HitIsInstigatorPlayerPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
