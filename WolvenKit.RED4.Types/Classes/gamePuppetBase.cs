
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePuppetBase : gameTimeDilatable
	{
		public gamePuppetBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
