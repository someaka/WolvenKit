
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePlayerTakeControlAsChild : redEvent
	{
		public gamePlayerTakeControlAsChild()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
