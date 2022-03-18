
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QhackExecuted : redEvent
	{
		public QhackExecuted()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
