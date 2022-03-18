
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entHardAttachment : entITransformAttachment
	{
		public entHardAttachment()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
