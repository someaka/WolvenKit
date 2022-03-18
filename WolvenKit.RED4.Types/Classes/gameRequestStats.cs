
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameRequestStats : redEvent
	{
		public gameRequestStats()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
