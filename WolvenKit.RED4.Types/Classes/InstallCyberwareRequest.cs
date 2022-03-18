
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InstallCyberwareRequest : gameEquipRequest
	{
		public InstallCyberwareRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
