
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISquadMemberBase : ISerializable
	{
		public AISquadMemberBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
