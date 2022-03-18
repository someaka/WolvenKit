
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnregisterAggressiveCrowd : redEvent
	{
		public UnregisterAggressiveCrowd()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
