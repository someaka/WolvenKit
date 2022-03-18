
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CrowdMemberBaseComponent : gameCrowdMemberComponent
	{
		public CrowdMemberBaseComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
