
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RemotelyConnectToAccessPoint : gameEffectExecutor_Scripted
	{
		public RemotelyConnectToAccessPoint()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
