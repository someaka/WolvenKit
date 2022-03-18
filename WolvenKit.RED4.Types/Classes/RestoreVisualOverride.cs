
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RestoreVisualOverride : redEvent
	{
		public RestoreVisualOverride()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
