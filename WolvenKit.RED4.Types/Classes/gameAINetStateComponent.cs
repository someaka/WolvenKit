
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAINetStateComponent : gameScriptableComponent
	{
		public gameAINetStateComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
