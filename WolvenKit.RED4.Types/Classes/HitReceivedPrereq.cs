
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitReceivedPrereq : GenericHitPrereq
	{
		public HitReceivedPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
