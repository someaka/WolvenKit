
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MinimapDataNodeInstance : worldINodeInstance
	{
		public MinimapDataNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
