
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetTemporaryIndividualTimeDilation : gameEffectExecutor_Scripted
	{
		public SetTemporaryIndividualTimeDilation()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
