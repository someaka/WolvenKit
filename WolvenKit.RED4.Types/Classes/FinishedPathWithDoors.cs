
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FinishedPathWithDoors : redEvent
	{
		public FinishedPathWithDoors()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
