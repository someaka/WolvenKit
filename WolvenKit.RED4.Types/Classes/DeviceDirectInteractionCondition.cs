
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceDirectInteractionCondition : gameinteractionsInteractionScriptedCondition
	{
		public DeviceDirectInteractionCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
