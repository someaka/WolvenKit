
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeSafeEvents : MeleePublicSafeEvents
	{
		public MeleeSafeEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
