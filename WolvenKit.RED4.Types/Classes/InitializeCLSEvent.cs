
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InitializeCLSEvent : redEvent
	{
		public InitializeCLSEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
