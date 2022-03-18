
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActionBool : ScriptableDeviceAction
	{
		public ActionBool()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
