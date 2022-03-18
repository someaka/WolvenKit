
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISquadNPCMember : AISquadMemberBase
	{
		public AISquadNPCMember()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
