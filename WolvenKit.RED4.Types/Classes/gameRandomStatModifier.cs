
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameRandomStatModifier : gameStatModifierBase
	{
		public gameRandomStatModifier()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
