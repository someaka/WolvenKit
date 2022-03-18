
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EnableTimeCallbacks : redEvent
	{
		public EnableTimeCallbacks()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
