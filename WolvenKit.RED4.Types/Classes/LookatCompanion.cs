
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LookatCompanion : AIGenericAdvancedLookatTask
	{
		public LookatCompanion()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
