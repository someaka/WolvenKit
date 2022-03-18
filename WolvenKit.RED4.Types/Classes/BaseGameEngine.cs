
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseGameEngine : CBaseEngine
	{
		public BaseGameEngine()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
