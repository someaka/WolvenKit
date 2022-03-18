
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemCamera : worldIRuntimeSystem
	{
		public worldRuntimeSystemCamera()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
