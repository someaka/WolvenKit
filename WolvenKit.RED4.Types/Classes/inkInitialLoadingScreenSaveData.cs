
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkInitialLoadingScreenSaveData : inkILoadingScreenPersistentData
	{
		public inkInitialLoadingScreenSaveData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
