
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entSlotPositionProvider : entIPositionProvider
	{
		public entSlotPositionProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
