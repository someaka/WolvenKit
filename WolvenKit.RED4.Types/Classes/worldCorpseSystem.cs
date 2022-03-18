
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldCorpseSystem : worldIRuntimeSystem
	{
		public worldCorpseSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
