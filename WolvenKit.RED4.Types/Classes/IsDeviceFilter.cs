
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsDeviceFilter : gameEffectObjectSingleFilter_Scripted
	{
		public IsDeviceFilter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
