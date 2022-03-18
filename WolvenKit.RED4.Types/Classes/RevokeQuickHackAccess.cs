
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RevokeQuickHackAccess : redEvent
	{
		public RevokeQuickHackAccess()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
