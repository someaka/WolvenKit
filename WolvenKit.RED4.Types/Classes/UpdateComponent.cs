
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UpdateComponent : gameScriptableComponent
	{
		public UpdateComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
