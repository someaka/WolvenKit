
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OnOffPrereq : gameIScriptablePrereq
	{
		public OnOffPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
