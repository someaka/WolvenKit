
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkLoadingLayer : inkFullScreenLayer
	{
		public inkLoadingLayer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
