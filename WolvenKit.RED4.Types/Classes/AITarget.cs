
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AITarget : AIITarget
	{
		public AITarget()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
