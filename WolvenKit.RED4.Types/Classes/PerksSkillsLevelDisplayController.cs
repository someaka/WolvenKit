using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PerksSkillsLevelDisplayController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("tint")] 
		public inkWidgetReference Tint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public PerksSkillsLevelDisplayController()
		{
			Tint = new();
		}
	}
}
