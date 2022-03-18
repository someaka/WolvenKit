
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TestScriptableComponent : gameScriptableComponent
	{
		public TestScriptableComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
