
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameConstantStatModifier : gameStatModifierBase
	{
		public gameConstantStatModifier()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
