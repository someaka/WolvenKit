
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectPostAction_Scripted : gameEffectPostAction
	{
		public gameEffectPostAction_Scripted()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
