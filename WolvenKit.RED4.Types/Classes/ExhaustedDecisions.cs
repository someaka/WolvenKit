
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExhaustedDecisions : StaminaTransition
	{
		public ExhaustedDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
