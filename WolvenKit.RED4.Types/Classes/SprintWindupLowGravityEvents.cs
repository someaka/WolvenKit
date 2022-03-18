
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SprintWindupLowGravityEvents : SprintLowGravityEvents
	{
		public SprintWindupLowGravityEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
