namespace WolvenKit.RED4.Types;

public partial class inkSettingsSelectorControllerKeyBinding : inkSettingsSelectorController
{
	[Ordinal(15)] 
	[RED("text")] 
	public inkRichTextBoxWidgetReference Text
	{
		get => GetPropertyValue<inkRichTextBoxWidgetReference>();
		set => SetPropertyValue<inkRichTextBoxWidgetReference>(value);
	}

	[Ordinal(16)] 
	[RED("buttonRef")] 
	public inkWidgetReference ButtonRef
	{
		get => GetPropertyValue<inkWidgetReference>();
		set => SetPropertyValue<inkWidgetReference>(value);
	}

	[Ordinal(17)] 
	[RED("editView")] 
	public inkWidgetReference EditView
	{
		get => GetPropertyValue<inkWidgetReference>();
		set => SetPropertyValue<inkWidgetReference>(value);
	}

	[Ordinal(18)] 
	[RED("editOpacity")] 
	public CFloat EditOpacity
	{
		get => GetPropertyValue<CFloat>();
		set => SetPropertyValue<CFloat>(value);
	}

	public inkSettingsSelectorControllerKeyBinding()
	{
		Text = new();
		ButtonRef = new();
		EditView = new();
		EditOpacity = 0.400000F;

		PostConstruct();
	}

	partial void PostConstruct();
}
