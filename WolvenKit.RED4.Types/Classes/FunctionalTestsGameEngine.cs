
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FunctionalTestsGameEngine : CGameEngine
	{
		public FunctionalTestsGameEngine()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
