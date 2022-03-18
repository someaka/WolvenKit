
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UpdateVisibilityModifierEvent : redEvent
	{
		public UpdateVisibilityModifierEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
