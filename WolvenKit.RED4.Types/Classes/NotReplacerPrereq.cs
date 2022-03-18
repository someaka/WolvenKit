
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NotReplacerPrereq : gameIScriptablePrereq
	{
		public NotReplacerPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
