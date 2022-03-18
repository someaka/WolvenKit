
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HideIconModuleEvent : redEvent
	{
		public HideIconModuleEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
