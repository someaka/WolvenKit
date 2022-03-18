
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIDefAI : AIResourceReference
	{
		public AIDefAI()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
