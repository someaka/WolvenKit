
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EndOne : DefaultTest
	{
		public EndOne()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
