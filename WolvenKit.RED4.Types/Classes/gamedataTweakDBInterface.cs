
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataTweakDBInterface : IScriptable
	{
		public gamedataTweakDBInterface()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
