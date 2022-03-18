
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Blacklist : MorphData
	{
		public Blacklist()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
