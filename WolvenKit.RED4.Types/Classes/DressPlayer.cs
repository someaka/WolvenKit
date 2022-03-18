
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DressPlayer : redEvent
	{
		public DressPlayer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
