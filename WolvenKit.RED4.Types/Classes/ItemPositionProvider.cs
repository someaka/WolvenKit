
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemPositionProvider : inkItemPositionProviderWrapper
	{
		public ItemPositionProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
