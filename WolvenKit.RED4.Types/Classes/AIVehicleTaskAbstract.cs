
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIVehicleTaskAbstract : AIbehaviortaskScript
	{
		public AIVehicleTaskAbstract()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
