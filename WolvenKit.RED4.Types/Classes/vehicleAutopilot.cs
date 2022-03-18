
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleAutopilot : RedBaseClass
	{
		public vehicleAutopilot()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
