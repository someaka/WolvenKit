using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAttachmentSlotData : RedBaseClass
	{
		private TweakDBID _slotID;
		private CHandle<gameItemObject> _itemObject;
		private gameItemID _activeItemID;
		private gameItemID _prevItemID;

		[Ordinal(0)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(1)] 
		[RED("itemObject")] 
		public CHandle<gameItemObject> ItemObject
		{
			get => GetProperty(ref _itemObject);
			set => SetProperty(ref _itemObject, value);
		}

		[Ordinal(2)] 
		[RED("activeItemID")] 
		public gameItemID ActiveItemID
		{
			get => GetProperty(ref _activeItemID);
			set => SetProperty(ref _activeItemID, value);
		}

		[Ordinal(3)] 
		[RED("prevItemID")] 
		public gameItemID PrevItemID
		{
			get => GetProperty(ref _prevItemID);
			set => SetProperty(ref _prevItemID, value);
		}
	}
}
