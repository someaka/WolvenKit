
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UpdateDamageChangeEvent : redEvent
	{
		public UpdateDamageChangeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
