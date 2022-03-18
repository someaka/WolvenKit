
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class cpConveyorSetupEvent : redEvent
	{
		public cpConveyorSetupEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
