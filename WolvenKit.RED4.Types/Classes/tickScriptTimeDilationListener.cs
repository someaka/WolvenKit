
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class tickScriptTimeDilationListener : tickITimeDilationListener
	{
		public tickScriptTimeDilationListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
