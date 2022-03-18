
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StealthState : ChangeHighLevelStateAbstract
	{
		public StealthState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
