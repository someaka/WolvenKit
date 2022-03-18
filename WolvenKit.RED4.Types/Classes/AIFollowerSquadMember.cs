
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIFollowerSquadMember : AISquadNPCMember
	{
		public AIFollowerSquadMember()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
