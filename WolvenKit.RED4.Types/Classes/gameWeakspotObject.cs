
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameWeakspotObject : gameObject
	{
		public gameWeakspotObject()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
