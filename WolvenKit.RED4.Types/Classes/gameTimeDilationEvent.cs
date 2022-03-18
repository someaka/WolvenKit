
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTimeDilationEvent : redEvent
	{
		public gameTimeDilationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
