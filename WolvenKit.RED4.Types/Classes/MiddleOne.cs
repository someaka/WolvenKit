
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MiddleOne : DefaultTest
	{
		public MiddleOne()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
