
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DurabilityComponent : gameScriptableComponent
	{
		public DurabilityComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
