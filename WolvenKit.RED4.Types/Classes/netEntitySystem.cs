
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class netEntitySystem : worldIRuntimeSystem
	{
		public netEntitySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
