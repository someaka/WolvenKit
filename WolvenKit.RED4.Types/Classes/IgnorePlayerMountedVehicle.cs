
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IgnorePlayerMountedVehicle : gameEffectObjectSingleFilter_Scripted
	{
		public IgnorePlayerMountedVehicle()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
