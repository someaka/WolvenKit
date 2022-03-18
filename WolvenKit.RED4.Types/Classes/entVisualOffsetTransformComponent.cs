
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entVisualOffsetTransformComponent : entTransformComponent
	{
		public entVisualOffsetTransformComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
