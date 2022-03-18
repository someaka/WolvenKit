
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FinisherEffector : ApplyStatusEffectEffector
	{
		public FinisherEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
