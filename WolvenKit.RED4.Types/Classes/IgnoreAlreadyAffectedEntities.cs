
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IgnoreAlreadyAffectedEntities : gameEffectObjectSingleFilter_Scripted
	{
		public IgnoreAlreadyAffectedEntities()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
