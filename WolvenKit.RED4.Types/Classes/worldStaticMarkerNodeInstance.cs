
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldStaticMarkerNodeInstance : worldSocketNodeInstance
	{
		public worldStaticMarkerNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
