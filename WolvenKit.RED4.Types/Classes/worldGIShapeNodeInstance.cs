
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldGIShapeNodeInstance : worldGeometryShapeNodeInstance
	{
		public worldGIShapeNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
