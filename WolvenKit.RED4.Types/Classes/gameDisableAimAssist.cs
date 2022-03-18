
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDisableAimAssist : redEvent
	{
		public gameDisableAimAssist()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
