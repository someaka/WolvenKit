
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CWindImpulseCollector : ISceneStorageCustomData
	{
		public CWindImpulseCollector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
