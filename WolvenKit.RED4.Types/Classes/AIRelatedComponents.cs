
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIRelatedComponents : gameScriptableComponent
	{
		public AIRelatedComponents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
