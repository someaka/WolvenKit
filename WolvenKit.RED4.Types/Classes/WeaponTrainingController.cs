
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeaponTrainingController : ScriptableDeviceComponent
	{
		public WeaponTrainingController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
