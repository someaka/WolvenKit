
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnlimitedUnlocked : redEvent
	{
		public UnlimitedUnlocked()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
