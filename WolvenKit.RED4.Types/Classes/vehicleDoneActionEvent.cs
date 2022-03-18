
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleDoneActionEvent : redEvent
	{
		public vehicleDoneActionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
