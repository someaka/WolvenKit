
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class effectCameraComponentSpawner : effectSpawner
	{
		public effectCameraComponentSpawner()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
