
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ConsumableTransitions : DefaultTransition
	{
		public ConsumableTransitions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
