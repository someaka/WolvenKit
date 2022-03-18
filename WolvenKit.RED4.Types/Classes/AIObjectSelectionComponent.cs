
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIObjectSelectionComponent : entIComponent
	{
		public AIObjectSelectionComponent()
		{
			Name = "ObjectSelector";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
