
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LookAtPresetMeleeBaseEvents : LookAtPresetBaseEvents
	{
		public LookAtPresetMeleeBaseEvents()
		{
			LookAtEvents = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
