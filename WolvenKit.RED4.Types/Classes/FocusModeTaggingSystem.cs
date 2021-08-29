using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FocusModeTaggingSystem : gameScriptableSystem
	{
		private CUInt32 _playerAttachedCallbackID;
		private CUInt32 _playerDetachedCallbackID;
		private CArray<CHandle<redCallbackObject>> _taggedListenerCallbacks;

		[Ordinal(0)] 
		[RED("playerAttachedCallbackID")] 
		public CUInt32 PlayerAttachedCallbackID
		{
			get => GetProperty(ref _playerAttachedCallbackID);
			set => SetProperty(ref _playerAttachedCallbackID, value);
		}

		[Ordinal(1)] 
		[RED("playerDetachedCallbackID")] 
		public CUInt32 PlayerDetachedCallbackID
		{
			get => GetProperty(ref _playerDetachedCallbackID);
			set => SetProperty(ref _playerDetachedCallbackID, value);
		}

		[Ordinal(2)] 
		[RED("taggedListenerCallbacks")] 
		public CArray<CHandle<redCallbackObject>> TaggedListenerCallbacks
		{
			get => GetProperty(ref _taggedListenerCallbacks);
			set => SetProperty(ref _taggedListenerCallbacks, value);
		}
	}
}
