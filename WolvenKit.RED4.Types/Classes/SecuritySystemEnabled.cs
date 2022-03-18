
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecuritySystemEnabled : redEvent
	{
		public SecuritySystemEnabled()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
