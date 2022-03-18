
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SimpleTargetManager : gameScriptableComponent
	{
		public SimpleTargetManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
