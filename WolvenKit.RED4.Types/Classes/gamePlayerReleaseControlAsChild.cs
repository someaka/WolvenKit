
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePlayerReleaseControlAsChild : redEvent
	{
		public gamePlayerReleaseControlAsChild()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
