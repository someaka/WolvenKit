
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerDevUpdateDataEvent : redEvent
	{
		public PlayerDevUpdateDataEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
