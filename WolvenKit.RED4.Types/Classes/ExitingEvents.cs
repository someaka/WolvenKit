
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExitingEvents : ExitingEventsBase
	{
		public ExitingEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
