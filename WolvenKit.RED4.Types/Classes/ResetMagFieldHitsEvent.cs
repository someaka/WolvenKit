
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResetMagFieldHitsEvent : redEvent
	{
		public ResetMagFieldHitsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
