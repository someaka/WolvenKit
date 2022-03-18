
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BeginOne : DefaultTest
	{
		public BeginOne()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
