
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimDebuggerCommand_GetAvailableHooks : animIAnimDebuggerCommand
	{
		public animAnimDebuggerCommand_GetAvailableHooks()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
