
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entUncontrolledMovementEndEvent : redEvent
	{
		public entUncontrolledMovementEndEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
