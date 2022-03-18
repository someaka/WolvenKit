
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entWetnessComponent : entIComponent
	{
		public entWetnessComponent()
		{
			Name = "wetness";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
