
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TweakAISubAction : IScriptable
	{
		public TweakAISubAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
