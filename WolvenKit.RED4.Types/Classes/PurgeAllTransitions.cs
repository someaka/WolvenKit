
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PurgeAllTransitions : redEvent
	{
		public PurgeAllTransitions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
