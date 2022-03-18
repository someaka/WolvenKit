
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class movePoliciesComponent : entIComponent
	{
		public movePoliciesComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
