
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectAction : IScriptable
	{
		public gameEffectAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
