
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RevealPlayerPositionEffector : gameEffector
	{
		public RevealPlayerPositionEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
