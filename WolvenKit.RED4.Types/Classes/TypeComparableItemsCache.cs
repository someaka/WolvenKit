namespace WolvenKit.RED4.Types;

public partial class TypeComparableItemsCache : IScriptable
{
	[Ordinal(0)] 
	[RED("cache")] 
	public CHandle<ItemComparableTypesCache> Cache
	{
		get => GetPropertyValue<CHandle<ItemComparableTypesCache>>();
		set => SetPropertyValue<CHandle<ItemComparableTypesCache>>(value);
	}

	[Ordinal(1)] 
	[RED("items")] 
	public CArray<InventoryItemData> Items
	{
		get => GetPropertyValue<CArray<InventoryItemData>>();
		set => SetPropertyValue<CArray<InventoryItemData>>(value);
	}

	public TypeComparableItemsCache()
	{
		Items = new();

		PostConstruct();
	}

	partial void PostConstruct();
}
