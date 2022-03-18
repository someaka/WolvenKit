
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RelaxedState : ChangeHighLevelStateAbstract
	{
		public RelaxedState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
