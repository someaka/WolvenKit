
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IEvaluator : ISerializable
	{
		public IEvaluator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
