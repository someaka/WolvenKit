
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class mpRemotePlayer : mpPlayer
	{
		public mpRemotePlayer()
		{
			PeerID = new() { Value = 255 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
