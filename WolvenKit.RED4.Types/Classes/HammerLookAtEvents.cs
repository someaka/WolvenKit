
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HammerLookAtEvents : LookAtPresetMeleeBaseEvents
	{
		public HammerLookAtEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
