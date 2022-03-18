
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IEvaluatorFloat : IEvaluator
	{
		public IEvaluatorFloat()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
