
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questGraphDefinition : graphGraphDefinition
	{
		public questGraphDefinition()
		{
			Nodes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
