
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeadBodyEvent : redEvent
	{
		public DeadBodyEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
