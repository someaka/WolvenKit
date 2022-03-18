
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SysDebuggerEvent : gameTickableEvent
	{
		public SysDebuggerEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
