
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldNullMarker : worldIMarker
	{
		public worldNullMarker()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
