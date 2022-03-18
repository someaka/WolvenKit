
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemEffectAttachments : worldIRuntimeSystem
	{
		public worldRuntimeSystemEffectAttachments()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
