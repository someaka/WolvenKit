
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeadState : ChangeHighLevelStateAbstract
	{
		public DeadState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
