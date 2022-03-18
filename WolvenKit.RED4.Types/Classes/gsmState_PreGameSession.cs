
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gsmState_PreGameSession : gsmState_Session
	{
		public gsmState_PreGameSession()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
