
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WoundedLookatController : AIGenericEntityLookatTask
	{
		public WoundedLookatController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
