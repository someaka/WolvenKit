
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActionName : ScriptableDeviceAction
	{
		public ActionName()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
