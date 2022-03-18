
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entSimpleSkinningAttachment : entISkinningAttachment
	{
		public entSimpleSkinningAttachment()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
