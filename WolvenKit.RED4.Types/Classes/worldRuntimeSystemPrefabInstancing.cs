
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemPrefabInstancing : worldIRuntimeSystem
	{
		public worldRuntimeSystemPrefabInstancing()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
