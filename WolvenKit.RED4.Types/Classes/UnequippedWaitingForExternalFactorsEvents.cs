
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnequippedWaitingForExternalFactorsEvents : EquipmentBaseEvents
	{
		public UnequippedWaitingForExternalFactorsEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
