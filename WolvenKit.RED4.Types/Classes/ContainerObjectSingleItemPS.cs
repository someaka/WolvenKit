
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ContainerObjectSingleItemPS : gameLootContainerBasePS
	{
		public ContainerObjectSingleItemPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
