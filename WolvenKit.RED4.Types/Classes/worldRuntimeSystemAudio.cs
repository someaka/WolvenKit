
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemAudio : worldIRuntimeSystem
	{
		public worldRuntimeSystemAudio()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
