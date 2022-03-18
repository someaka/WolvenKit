
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePlayerReleaseControlAsParent : redEvent
	{
		public gamePlayerReleaseControlAsParent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
