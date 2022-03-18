
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActionEntityReference : ScriptableDeviceAction
	{
		public ActionEntityReference()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
