
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Validate : redEvent
	{
		public Validate()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
