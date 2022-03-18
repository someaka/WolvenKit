
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIWeapon : IScriptable
	{
		public AIWeapon()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
