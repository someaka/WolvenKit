
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerGameplayRestrictions : IScriptable
	{
		public PlayerGameplayRestrictions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
