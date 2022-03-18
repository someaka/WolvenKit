
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCIncapacitatedPrereq : gameIScriptablePrereq
	{
		public NPCIncapacitatedPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
