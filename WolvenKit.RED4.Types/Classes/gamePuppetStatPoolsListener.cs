
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePuppetStatPoolsListener : gameIStatPoolsListener
	{
		public gamePuppetStatPoolsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
