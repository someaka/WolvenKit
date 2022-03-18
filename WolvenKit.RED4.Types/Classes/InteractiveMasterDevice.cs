
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InteractiveMasterDevice : InteractiveDevice
	{
		public InteractiveMasterDevice()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
