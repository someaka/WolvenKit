
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EffectDataHelper : IScriptable
	{
		public EffectDataHelper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
