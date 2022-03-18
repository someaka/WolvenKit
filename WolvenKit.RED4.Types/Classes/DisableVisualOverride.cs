
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisableVisualOverride : redEvent
	{
		public DisableVisualOverride()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
