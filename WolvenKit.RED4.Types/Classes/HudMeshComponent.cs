
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HudMeshComponent : entMeshComponent
	{
		public HudMeshComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
