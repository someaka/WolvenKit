
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AlwaysTruePrereq : gameIScriptablePrereq
	{
		public AlwaysTruePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
