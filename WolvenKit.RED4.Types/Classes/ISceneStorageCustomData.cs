
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ISceneStorageCustomData : RedBaseClass
	{
		public ISceneStorageCustomData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
