
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VirtualComponentBinder : RedBaseClass
	{
		public VirtualComponentBinder()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
