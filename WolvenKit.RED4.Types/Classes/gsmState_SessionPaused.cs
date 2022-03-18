
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gsmState_SessionPaused : gsmState_SessionStreamingAware
	{
		public gsmState_SessionPaused()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
