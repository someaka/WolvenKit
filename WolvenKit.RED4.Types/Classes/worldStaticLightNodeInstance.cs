
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldStaticLightNodeInstance : worldINodeInstance
	{
		public worldStaticLightNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
