
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCDeadPrereq : gameIScriptablePrereq
	{
		public NPCDeadPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
