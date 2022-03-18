
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class mpServerGameSession : mpGameSession
	{
		public mpServerGameSession()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
