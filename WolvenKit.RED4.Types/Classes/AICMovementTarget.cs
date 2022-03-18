
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICMovementTarget : AIPosition
	{
		public AICMovementTarget()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
