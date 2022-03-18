
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entEditorMeshComponent : entMeshComponent
	{
		public entEditorMeshComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
