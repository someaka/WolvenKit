
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCRevealedPrereq : gameIScriptablePrereq
	{
		public NPCRevealedPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
