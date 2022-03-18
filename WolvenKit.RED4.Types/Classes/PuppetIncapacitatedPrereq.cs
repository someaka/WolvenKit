
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PuppetIncapacitatedPrereq : gameIScriptablePrereq
	{
		public PuppetIncapacitatedPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
