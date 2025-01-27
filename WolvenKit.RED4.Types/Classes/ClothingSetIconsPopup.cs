using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ClothingSetIconsPopup : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("iconGrid")] 
		public inkWidgetReference IconGrid
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("buttonHintsRoot")] 
		public inkWidgetReference ButtonHintsRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("data")] 
		public CHandle<ClothingSetIconsPopupOpenData> Data
		{
			get => GetPropertyValue<CHandle<ClothingSetIconsPopupOpenData>>();
			set => SetPropertyValue<CHandle<ClothingSetIconsPopupOpenData>>(value);
		}

		[Ordinal(5)] 
		[RED("libraryPath")] 
		public inkWidgetLibraryReference LibraryPath
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
		}

		public ClothingSetIconsPopup()
		{
			IconGrid = new();
			ButtonHintsRoot = new();
			LibraryPath = new() { WidgetLibrary = new() };
		}
	}
}
