
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisableAllWorldInteractionsNotEnabledPrereq : gameIScriptablePrereq
	{
		public DisableAllWorldInteractionsNotEnabledPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
