
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecuritySystemDisabled : redEvent
	{
		public SecuritySystemDisabled()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
