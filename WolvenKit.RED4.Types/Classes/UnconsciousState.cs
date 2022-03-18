
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnconsciousState : ChangeHighLevelStateAbstract
	{
		public UnconsciousState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
