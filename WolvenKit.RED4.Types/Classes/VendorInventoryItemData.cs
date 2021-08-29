using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendorInventoryItemData : WrappedInventoryItemData
	{
		private CBool _isVendorItem;
		private CBool _isEnoughMoney;
		private CBool _isBuybackStack;

		[Ordinal(5)] 
		[RED("IsVendorItem")] 
		public CBool IsVendorItem
		{
			get => GetProperty(ref _isVendorItem);
			set => SetProperty(ref _isVendorItem, value);
		}

		[Ordinal(6)] 
		[RED("IsEnoughMoney")] 
		public CBool IsEnoughMoney
		{
			get => GetProperty(ref _isEnoughMoney);
			set => SetProperty(ref _isEnoughMoney, value);
		}

		[Ordinal(7)] 
		[RED("IsBuybackStack")] 
		public CBool IsBuybackStack
		{
			get => GetProperty(ref _isBuybackStack);
			set => SetProperty(ref _isBuybackStack, value);
		}
	}
}
