
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class mpGameSession : gameBaseGameSession
	{
		public mpGameSession()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
