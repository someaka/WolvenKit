
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class mpPlayer : gamePlayer
	{
		public mpPlayer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
