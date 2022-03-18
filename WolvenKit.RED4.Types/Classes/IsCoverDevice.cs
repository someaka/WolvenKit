
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsCoverDevice : gameEffectObjectSingleFilter_Scripted
	{
		public IsCoverDevice()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
