
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkInitialLoadingScreenData : inkILoadingScreenData
	{
		public inkInitialLoadingScreenData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
