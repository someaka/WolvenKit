
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MinigameFailEvent : redEvent
	{
		public MinigameFailEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
