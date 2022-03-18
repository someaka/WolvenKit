
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIUnmountCommand : AIBaseMountCommand
	{
		public AIUnmountCommand()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
