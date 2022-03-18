
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameWasScannedPrereq : gameIPrereq
	{
		public gameWasScannedPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
