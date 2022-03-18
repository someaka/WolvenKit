
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TemporaryUnequipDecisions : UpperBodyTransition
	{
		public TemporaryUnequipDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
