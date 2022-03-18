
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StandState : ChangeStanceStateAbstract
	{
		public StandState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
