
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GenericNotificationBaseAction : IScriptable
	{
		public GenericNotificationBaseAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
