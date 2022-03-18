
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class redTOMLKeyValue : redTOMLBaseValue
	{
		public redTOMLKeyValue()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
