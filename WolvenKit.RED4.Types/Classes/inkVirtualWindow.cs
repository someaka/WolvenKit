
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkVirtualWindow : inkWindow
	{
		public inkVirtualWindow()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
