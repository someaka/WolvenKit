
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActionFloat : ScriptableDeviceAction
	{
		public ActionFloat()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
