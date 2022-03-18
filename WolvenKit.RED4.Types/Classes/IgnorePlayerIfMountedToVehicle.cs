
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IgnorePlayerIfMountedToVehicle : gameEffectObjectSingleFilter_Scripted
	{
		public IgnorePlayerIfMountedToVehicle()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
