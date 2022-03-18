
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldEffectBlackboard : IScriptable
	{
		public worldEffectBlackboard()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
