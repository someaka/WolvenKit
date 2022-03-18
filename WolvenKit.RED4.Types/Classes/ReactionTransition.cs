
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ReactionTransition : DefaultTransition
	{
		public ReactionTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
