
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class mpClientGameSession : mpGameSession
	{
		public mpClientGameSession()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
