
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEnableAimAssist : redEvent
	{
		public gameEnableAimAssist()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
