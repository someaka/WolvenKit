
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkInitialLoadingControllerSupervisor : gameuiOnscreenVOPlayerController
	{
		public inkInitialLoadingControllerSupervisor()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
