
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePreviewItemData : gameUniqueItemData
	{
		public gamePreviewItemData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
