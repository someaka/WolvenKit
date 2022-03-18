
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InStandStanceState : AINPCStanceStateCheck
	{
		public InStandStanceState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
