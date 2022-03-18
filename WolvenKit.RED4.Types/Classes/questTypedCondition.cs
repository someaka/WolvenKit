
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questTypedCondition : questIBaseCondition
	{
		public questTypedCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
