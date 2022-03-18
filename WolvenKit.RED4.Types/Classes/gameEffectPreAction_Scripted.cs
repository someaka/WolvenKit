
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectPreAction_Scripted : gameEffectPreAction
	{
		public gameEffectPreAction_Scripted()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
