
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WaitBeforeExiting : AIVehicleTaskAbstract
	{
		public WaitBeforeExiting()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
