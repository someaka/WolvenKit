
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DispenseFreeItem : redEvent
	{
		public DispenseFreeItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
