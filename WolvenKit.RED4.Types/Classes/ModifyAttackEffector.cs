
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ModifyAttackEffector : gameEffector
	{
		public ModifyAttackEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
