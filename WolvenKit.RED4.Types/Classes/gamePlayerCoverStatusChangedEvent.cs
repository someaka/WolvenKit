using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePlayerCoverStatusChangedEvent : redEvent
	{
		private CEnum<gamePlayerCoverDirection> _direction;
		private CBool _fullyBehindCover;

		[Ordinal(0)] 
		[RED("direction")] 
		public CEnum<gamePlayerCoverDirection> Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		[Ordinal(1)] 
		[RED("fullyBehindCover")] 
		public CBool FullyBehindCover
		{
			get => GetProperty(ref _fullyBehindCover);
			set => SetProperty(ref _fullyBehindCover, value);
		}
	}
}
