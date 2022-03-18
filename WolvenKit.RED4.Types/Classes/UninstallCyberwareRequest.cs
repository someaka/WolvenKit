
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UninstallCyberwareRequest : UnequipRequest
	{
		public UninstallCyberwareRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
