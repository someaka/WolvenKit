
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkDebugLayer : inkFullScreenLayer
	{
		public inkDebugLayer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
