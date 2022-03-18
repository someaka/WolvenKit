
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIMountCommand : AIBaseMountCommand
	{
		public AIMountCommand()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
