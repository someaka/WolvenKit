
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCarriedObjectDestroy : redEvent
	{
		public gameCarriedObjectDestroy()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
