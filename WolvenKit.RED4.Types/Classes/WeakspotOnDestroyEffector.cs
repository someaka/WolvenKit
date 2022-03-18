
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeakspotOnDestroyEffector : gameEffector
	{
		public WeakspotOnDestroyEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
