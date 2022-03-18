
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectNode : IScriptable
	{
		public gameEffectNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
