using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiItemAddedNotificationViewData : gameuiGenericNotificationViewData
	{
		private gameItemID _itemID;
		private CName _animation;
		private CName _itemRarity;

		[Ordinal(5)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(6)] 
		[RED("animation")] 
		public CName Animation
		{
			get => GetProperty(ref _animation);
			set => SetProperty(ref _animation, value);
		}

		[Ordinal(7)] 
		[RED("itemRarity")] 
		public CName ItemRarity
		{
			get => GetProperty(ref _itemRarity);
			set => SetProperty(ref _itemRarity, value);
		}
	}
}
