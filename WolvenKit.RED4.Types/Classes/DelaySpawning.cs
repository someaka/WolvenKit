
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DelaySpawning : redEvent
	{
		public DelaySpawning()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
