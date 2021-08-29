using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimationsConstructor : IScriptable
	{
		private CFloat _duration;
		private CEnum<inkanimInterpolationType> _type;
		private CEnum<inkanimInterpolationMode> _mode;
		private CBool _isAdditive;

		[Ordinal(0)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<inkanimInterpolationType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(2)] 
		[RED("mode")] 
		public CEnum<inkanimInterpolationMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		[Ordinal(3)] 
		[RED("isAdditive")] 
		public CBool IsAdditive
		{
			get => GetProperty(ref _isAdditive);
			set => SetProperty(ref _isAdditive, value);
		}
	}
}
