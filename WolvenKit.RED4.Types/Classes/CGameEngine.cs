
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CGameEngine : BaseGameEngine
	{
		public CGameEngine()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
