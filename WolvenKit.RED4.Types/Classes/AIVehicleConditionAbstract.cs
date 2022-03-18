
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIVehicleConditionAbstract : AIbehaviorconditionScript
	{
		public AIVehicleConditionAbstract()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
