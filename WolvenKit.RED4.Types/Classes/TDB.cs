
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TDB : gamedataTweakDBInterface
	{
		public TDB()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
