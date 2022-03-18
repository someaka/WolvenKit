
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TurnOnVisibilitySenseComponent : redEvent
	{
		public TurnOnVisibilitySenseComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
