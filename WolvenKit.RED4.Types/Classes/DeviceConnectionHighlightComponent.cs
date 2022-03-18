
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceConnectionHighlightComponent : gameScriptableComponent
	{
		public DeviceConnectionHighlightComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
