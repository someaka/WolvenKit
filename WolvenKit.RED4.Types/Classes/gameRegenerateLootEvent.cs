
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameRegenerateLootEvent : redEvent
	{
		public gameRegenerateLootEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
