using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questIsInMirrorsAreaMapArrayElement : RedBaseClass
	{
		private NodeRef _objectRef;
		private CBool _isInMirrorsArea;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public NodeRef ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("isInMirrorsArea")] 
		public CBool IsInMirrorsArea
		{
			get => GetProperty(ref _isInMirrorsArea);
			set => SetProperty(ref _isInMirrorsArea, value);
		}
	}
}
