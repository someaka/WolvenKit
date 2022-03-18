
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameImpostorComponentAttachEvent : redEvent
	{
		public gameImpostorComponentAttachEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
