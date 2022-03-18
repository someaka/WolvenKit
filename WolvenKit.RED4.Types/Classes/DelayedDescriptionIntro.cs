
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DelayedDescriptionIntro : redEvent
	{
		public DelayedDescriptionIntro()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
