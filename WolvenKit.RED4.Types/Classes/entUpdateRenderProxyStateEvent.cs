
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entUpdateRenderProxyStateEvent : redEvent
	{
		public entUpdateRenderProxyStateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
