
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameUniqueItemData : gameItemData
	{
		public gameUniqueItemData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
