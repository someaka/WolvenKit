
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DropPointModule : Device
	{
		public DropPointModule()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
