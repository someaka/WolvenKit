
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActionNodeRef : ScriptableDeviceAction
	{
		public ActionNodeRef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
