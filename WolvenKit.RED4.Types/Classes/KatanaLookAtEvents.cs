
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class KatanaLookAtEvents : LookAtPresetMeleeBaseEvents
	{
		public KatanaLookAtEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
