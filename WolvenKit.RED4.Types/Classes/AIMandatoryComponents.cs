
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIMandatoryComponents : AIRelatedComponents
	{
		public AIMandatoryComponents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
