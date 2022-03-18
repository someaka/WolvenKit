
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EvaluateLootQualityEvent : redEvent
	{
		public EvaluateLootQualityEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
