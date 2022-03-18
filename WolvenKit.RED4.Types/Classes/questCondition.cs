
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCondition : questIBaseCondition
	{
		public questCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
