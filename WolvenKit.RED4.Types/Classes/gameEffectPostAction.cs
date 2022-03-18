
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectPostAction : gameEffectAction
	{
		public gameEffectPostAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
