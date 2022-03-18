
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AdHocAnimationEvents : TemporaryUnequipEvents
	{
		public AdHocAnimationEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
