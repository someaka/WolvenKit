
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldAISpotNodeInstance : worldSocketNodeInstance
	{
		public worldAISpotNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
