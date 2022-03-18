
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PatrolAction : TweakAIActionSmartComposite
	{
		public PatrolAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
