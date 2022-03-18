
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BackActionCallback : redEvent
	{
		public BackActionCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
