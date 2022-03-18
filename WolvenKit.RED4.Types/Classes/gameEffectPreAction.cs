
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectPreAction : gameEffectAction
	{
		public gameEffectPreAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
