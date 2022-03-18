
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ArcadeMachineBlackboardDef : DeviceBaseBlackboardDef
	{
		public ArcadeMachineBlackboardDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
