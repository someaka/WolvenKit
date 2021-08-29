using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PuppetForceVisionAppearanceData : IScriptable
	{
		private CEnum<EFocusForcedHighlightType> _highlightType;
		private CEnum<EFocusOutlineType> _outlineType;
		private CWeakHandle<gamedataStim_Record> _stimRecord;
		private CFloat _transitionTime;
		private CEnum<EPriority> _priority;
		private CArray<CWeakHandle<ScriptedPuppet>> _targets;
		private CArray<CWeakHandle<ScriptedPuppet>> _highlightedTargets;
		private CInt32 _investigationSlots;
		private CBool _sourceHighlighted;
		private CString _effectName;

		[Ordinal(0)] 
		[RED("highlightType")] 
		public CEnum<EFocusForcedHighlightType> HighlightType
		{
			get => GetProperty(ref _highlightType);
			set => SetProperty(ref _highlightType, value);
		}

		[Ordinal(1)] 
		[RED("outlineType")] 
		public CEnum<EFocusOutlineType> OutlineType
		{
			get => GetProperty(ref _outlineType);
			set => SetProperty(ref _outlineType, value);
		}

		[Ordinal(2)] 
		[RED("stimRecord")] 
		public CWeakHandle<gamedataStim_Record> StimRecord
		{
			get => GetProperty(ref _stimRecord);
			set => SetProperty(ref _stimRecord, value);
		}

		[Ordinal(3)] 
		[RED("transitionTime")] 
		public CFloat TransitionTime
		{
			get => GetProperty(ref _transitionTime);
			set => SetProperty(ref _transitionTime, value);
		}

		[Ordinal(4)] 
		[RED("priority")] 
		public CEnum<EPriority> Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(5)] 
		[RED("targets")] 
		public CArray<CWeakHandle<ScriptedPuppet>> Targets
		{
			get => GetProperty(ref _targets);
			set => SetProperty(ref _targets, value);
		}

		[Ordinal(6)] 
		[RED("highlightedTargets")] 
		public CArray<CWeakHandle<ScriptedPuppet>> HighlightedTargets
		{
			get => GetProperty(ref _highlightedTargets);
			set => SetProperty(ref _highlightedTargets, value);
		}

		[Ordinal(7)] 
		[RED("investigationSlots")] 
		public CInt32 InvestigationSlots
		{
			get => GetProperty(ref _investigationSlots);
			set => SetProperty(ref _investigationSlots, value);
		}

		[Ordinal(8)] 
		[RED("sourceHighlighted")] 
		public CBool SourceHighlighted
		{
			get => GetProperty(ref _sourceHighlighted);
			set => SetProperty(ref _sourceHighlighted, value);
		}

		[Ordinal(9)] 
		[RED("effectName")] 
		public CString EffectName
		{
			get => GetProperty(ref _effectName);
			set => SetProperty(ref _effectName, value);
		}
	}
}
