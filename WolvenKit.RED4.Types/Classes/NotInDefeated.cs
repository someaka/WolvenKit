
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NotInDefeated : gameEffectObjectSingleFilter_Scripted
	{
		public NotInDefeated()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
