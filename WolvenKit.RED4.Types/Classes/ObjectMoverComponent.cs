
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ObjectMoverComponent : gameScriptableComponent
	{
		public ObjectMoverComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
