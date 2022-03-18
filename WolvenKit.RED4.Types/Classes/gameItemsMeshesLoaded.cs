
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameItemsMeshesLoaded : redEvent
	{
		public gameItemsMeshesLoaded()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
