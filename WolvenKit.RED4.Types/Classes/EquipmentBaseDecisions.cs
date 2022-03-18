
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EquipmentBaseDecisions : EquipmentBaseTransition
	{
		public EquipmentBaseDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
