
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIScriptablePrereq : gameIPrereq
	{
		public gameIScriptablePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
