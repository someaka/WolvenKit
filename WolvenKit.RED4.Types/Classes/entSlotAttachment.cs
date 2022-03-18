
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entSlotAttachment : entITransformAttachment
	{
		public entSlotAttachment()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
