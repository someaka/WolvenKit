
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TestCaseBase_Backend : IScriptable
	{
		public TestCaseBase_Backend()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
