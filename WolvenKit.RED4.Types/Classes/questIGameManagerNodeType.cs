
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questIGameManagerNodeType : questISignalStoppingNodeType
	{
		public questIGameManagerNodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
