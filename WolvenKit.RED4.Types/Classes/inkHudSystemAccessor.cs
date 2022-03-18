
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkHudSystemAccessor : inkILayerSystemAccesor
	{
		public inkHudSystemAccessor()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
