
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questObjectInspectListener : questIInspectListener
	{
		public questObjectInspectListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
