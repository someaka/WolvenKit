
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EquipmentBaseEvents : EquipmentBaseTransition
	{
		public EquipmentBaseEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
