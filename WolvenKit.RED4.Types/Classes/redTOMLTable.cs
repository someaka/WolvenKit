
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class redTOMLTable : redTOMLBaseValue
	{
		public redTOMLTable()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
