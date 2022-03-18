
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficSpotNodeInstance : worldAISpotNodeInstance
	{
		public worldTrafficSpotNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
