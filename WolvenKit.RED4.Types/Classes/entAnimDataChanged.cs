
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAnimDataChanged : redEvent
	{
		public entAnimDataChanged()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
