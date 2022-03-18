
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class attrDynamicChoice : attrAttribute
	{
		public attrDynamicChoice()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
