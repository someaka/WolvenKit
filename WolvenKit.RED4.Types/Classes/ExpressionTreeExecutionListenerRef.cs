
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	[REDClass(SerializeDefault = true)]
	public partial class ExpressionTreeExecutionListenerRef : RedBaseClass
	{
		public ExpressionTreeExecutionListenerRef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
