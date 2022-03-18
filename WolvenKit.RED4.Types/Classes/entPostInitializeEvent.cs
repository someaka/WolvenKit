
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entPostInitializeEvent : redEvent
	{
		public entPostInitializeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
