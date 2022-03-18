
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TestEffector : gameEffector
	{
		public TestEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
