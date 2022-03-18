
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GlobalDeathCondition : AIDeathConditions
	{
		public GlobalDeathCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
