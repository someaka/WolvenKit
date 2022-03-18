
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisassembleEvent : redEvent
	{
		public DisassembleEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
