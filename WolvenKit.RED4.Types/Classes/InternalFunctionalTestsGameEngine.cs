
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InternalFunctionalTestsGameEngine : CGameEngine
	{
		public InternalFunctionalTestsGameEngine()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
