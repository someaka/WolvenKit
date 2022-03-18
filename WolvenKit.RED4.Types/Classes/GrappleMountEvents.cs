
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GrappleMountEvents : LocomotionTakedownEvents
	{
		public GrappleMountEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
