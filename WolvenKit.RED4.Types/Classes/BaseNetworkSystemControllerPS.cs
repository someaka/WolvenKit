
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseNetworkSystemControllerPS : MasterControllerPS
	{
		public BaseNetworkSystemControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
