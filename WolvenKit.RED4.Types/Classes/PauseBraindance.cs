
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PauseBraindance : redEvent
	{
		public PauseBraindance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
