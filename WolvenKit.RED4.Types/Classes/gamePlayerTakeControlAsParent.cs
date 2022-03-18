
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePlayerTakeControlAsParent : redEvent
	{
		public gamePlayerTakeControlAsParent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
