
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResetFacialEvent : redEvent
	{
		public ResetFacialEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
