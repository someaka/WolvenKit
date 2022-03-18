
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EvaluateEncumbranceEvent : redEvent
	{
		public EvaluateEncumbranceEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
