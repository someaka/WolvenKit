
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActionInt : ScriptableDeviceAction
	{
		public ActionInt()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
