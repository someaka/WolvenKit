
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UpdateGatePosition : redEvent
	{
		public UpdateGatePosition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
