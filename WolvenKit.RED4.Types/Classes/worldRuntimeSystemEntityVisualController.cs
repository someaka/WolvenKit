
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemEntityVisualController : worldIRuntimeSystem
	{
		public worldRuntimeSystemEntityVisualController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
