
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameGarmentItemObject : gameItemObject
	{
		public gameGarmentItemObject()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
