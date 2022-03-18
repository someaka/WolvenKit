
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameFootstepEvent : redEvent
	{
		public gameFootstepEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
