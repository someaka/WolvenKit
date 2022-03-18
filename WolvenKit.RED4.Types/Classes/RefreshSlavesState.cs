
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RefreshSlavesState : redEvent
	{
		public RefreshSlavesState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
