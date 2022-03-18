
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitReactionMechComponent : HitReactionComponent
	{
		public HitReactionMechComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
