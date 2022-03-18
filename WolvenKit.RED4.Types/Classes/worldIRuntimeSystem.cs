
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldIRuntimeSystem : IUpdatableSystem
	{
		public worldIRuntimeSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
