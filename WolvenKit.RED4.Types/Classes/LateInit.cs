
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LateInit : redEvent
	{
		public LateInit()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
