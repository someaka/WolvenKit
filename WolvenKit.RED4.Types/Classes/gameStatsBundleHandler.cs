
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameStatsBundleHandler : IScriptable
	{
		public gameStatsBundleHandler()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
