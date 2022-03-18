
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HighlightModule : HUDModule
	{
		public HighlightModule()
		{
			InstancesList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
