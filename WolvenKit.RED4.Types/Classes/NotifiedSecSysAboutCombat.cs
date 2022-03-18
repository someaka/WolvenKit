
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NotifiedSecSysAboutCombat : redEvent
	{
		public NotifiedSecSysAboutCombat()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
