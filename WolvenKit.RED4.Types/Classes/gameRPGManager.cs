
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameRPGManager : IScriptable
	{
		public gameRPGManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
