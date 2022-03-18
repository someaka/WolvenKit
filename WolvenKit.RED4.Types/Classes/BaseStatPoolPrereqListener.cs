
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseStatPoolPrereqListener : gameCustomValueStatPoolsListener
	{
		public BaseStatPoolPrereqListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
