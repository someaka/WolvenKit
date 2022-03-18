
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsScannerTarget : gameIScriptablePrereq
	{
		public IsScannerTarget()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
