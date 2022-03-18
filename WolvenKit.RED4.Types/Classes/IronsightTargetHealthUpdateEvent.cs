
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IronsightTargetHealthUpdateEvent : redEvent
	{
		public IronsightTargetHealthUpdateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
