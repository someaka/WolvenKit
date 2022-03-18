
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerPhone : gameScriptableComponent
	{
		public PlayerPhone()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
