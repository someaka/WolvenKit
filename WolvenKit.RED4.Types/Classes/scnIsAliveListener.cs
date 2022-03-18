
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnIsAliveListener : gameIStatPoolsListener
	{
		public scnIsAliveListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
