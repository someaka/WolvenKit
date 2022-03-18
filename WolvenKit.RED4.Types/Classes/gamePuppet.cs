
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePuppet : gamePuppetBase
	{
		public gamePuppet()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
