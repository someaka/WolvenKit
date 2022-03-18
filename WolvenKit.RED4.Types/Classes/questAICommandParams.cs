
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questAICommandParams : scnAICommandFactory
	{
		public questAICommandParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
