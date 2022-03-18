
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDynamicEventNodeInstance : worldAreaShapeNodeInstance
	{
		public gameDynamicEventNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
