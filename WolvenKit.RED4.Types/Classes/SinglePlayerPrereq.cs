
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SinglePlayerPrereq : gameIScriptablePrereq
	{
		public SinglePlayerPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
