
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsRefreshVisibility : redEvent
	{
		public gameeventsRefreshVisibility()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
