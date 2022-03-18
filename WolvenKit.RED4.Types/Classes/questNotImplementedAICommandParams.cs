
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questNotImplementedAICommandParams : questAICommandParams
	{
		public questNotImplementedAICommandParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
