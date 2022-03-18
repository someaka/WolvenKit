
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class redTOMLArrayTable : redTOMLBaseValue
	{
		public redTOMLArrayTable()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
