
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OnlySingleStatusEffectFromInstigator : gameEffectObjectSingleFilter_Scripted
	{
		public OnlySingleStatusEffectFromInstigator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
