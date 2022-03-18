
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SelectorTimeout : AITimeoutCondition
	{
		public SelectorTimeout()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
