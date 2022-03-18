
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class cpPlayerSystem : gamePlayerSystem
	{
		public cpPlayerSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
