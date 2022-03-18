
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EMPEnded : redEvent
	{
		public EMPEnded()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
