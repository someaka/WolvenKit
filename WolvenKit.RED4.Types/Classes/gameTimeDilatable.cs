
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTimeDilatable : gameObject
	{
		public gameTimeDilatable()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
