
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceRemoteInteractionCondition : gameinteractionsInteractionScriptedCondition
	{
		public DeviceRemoteInteractionCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
