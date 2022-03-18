
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class attrCommand : attrAttribute
	{
		public attrCommand()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
