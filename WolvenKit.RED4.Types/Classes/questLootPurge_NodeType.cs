
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questLootPurge_NodeType : questIGameManagerNonSignalStoppingNodeType
	{
		public questLootPurge_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
