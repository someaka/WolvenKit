
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkHUDLayer : inkFullScreenLayer
	{
		public inkHUDLayer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
