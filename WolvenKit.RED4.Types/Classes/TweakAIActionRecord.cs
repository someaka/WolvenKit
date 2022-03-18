
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TweakAIActionRecord : IScriptable
	{
		public TweakAIActionRecord()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
