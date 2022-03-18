
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entPreUninitializeEvent : redEvent
	{
		public entPreUninitializeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
