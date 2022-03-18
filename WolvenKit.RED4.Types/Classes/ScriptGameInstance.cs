
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScriptGameInstance : RedBaseClass
	{
		public ScriptGameInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
