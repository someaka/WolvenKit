
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameContainerObjectBasePS : gameLootContainerBasePS
	{
		public gameContainerObjectBasePS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
