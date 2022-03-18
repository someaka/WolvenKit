
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCarriedObjectAttached : redEvent
	{
		public gameCarriedObjectAttached()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
