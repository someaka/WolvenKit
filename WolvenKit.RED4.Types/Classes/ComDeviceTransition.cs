
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ComDeviceTransition : DefaultTransition
	{
		public ComDeviceTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
