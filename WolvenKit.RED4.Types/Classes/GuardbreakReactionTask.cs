using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GuardbreakReactionTask : AIHitReactionTask
	{
		[Ordinal(4)] 
		[RED("tweakDBPackage")] 
		public TweakDBID TweakDBPackage
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public GuardbreakReactionTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
