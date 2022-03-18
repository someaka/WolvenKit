
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameGameSession : gameBaseGameSession
	{
		public gameGameSession()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
