
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnCheckAnyoneDistractedInterruptCondition : scnIInterruptCondition
	{
		public scnCheckAnyoneDistractedInterruptCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
