
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIVehicleAgent : AICAgent
	{
		public AIVehicleAgent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
