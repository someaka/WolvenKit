
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickSlotsTransition : DefaultTransition
	{
		public QuickSlotsTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
