
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCIsHumanoidPrereq : gameIScriptablePrereq
	{
		public NPCIsHumanoidPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
