
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EnteredPathWithDoors : redEvent
	{
		public EnteredPathWithDoors()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
