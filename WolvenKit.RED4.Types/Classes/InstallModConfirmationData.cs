using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InstallModConfirmationData : IScriptable
	{
		private gameItemID _itemId;
		private gameItemID _partId;
		private TweakDBID _slotID;
		private gameTelemetryInventoryItem _telemetryItemData;
		private gameTelemetryInventoryItem _telemetryPartData;

		[Ordinal(0)] 
		[RED("itemId")] 
		public gameItemID ItemId
		{
			get => GetProperty(ref _itemId);
			set => SetProperty(ref _itemId, value);
		}

		[Ordinal(1)] 
		[RED("partId")] 
		public gameItemID PartId
		{
			get => GetProperty(ref _partId);
			set => SetProperty(ref _partId, value);
		}

		[Ordinal(2)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(3)] 
		[RED("telemetryItemData")] 
		public gameTelemetryInventoryItem TelemetryItemData
		{
			get => GetProperty(ref _telemetryItemData);
			set => SetProperty(ref _telemetryItemData, value);
		}

		[Ordinal(4)] 
		[RED("telemetryPartData")] 
		public gameTelemetryInventoryItem TelemetryPartData
		{
			get => GetProperty(ref _telemetryPartData);
			set => SetProperty(ref _telemetryPartData, value);
		}
	}
}
