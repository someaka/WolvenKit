using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AssignHotkeyIfEmptySlot : gamePlayerScriptableSystemRequest
	{
		private gameItemID _itemID;

		[Ordinal(1)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}
	}
}
