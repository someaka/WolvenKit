
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsDriverActive : AIVehicleConditionAbstract
	{
		public IsDriverActive()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
