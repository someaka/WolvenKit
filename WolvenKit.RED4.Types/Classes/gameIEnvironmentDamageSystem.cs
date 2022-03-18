
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIEnvironmentDamageSystem : gameIGameSystem
	{
		public gameIEnvironmentDamageSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
