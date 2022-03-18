
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TrapComponent : gameScriptableComponent
	{
		public TrapComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
