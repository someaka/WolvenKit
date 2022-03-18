
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RegisterTimeListeners : redEvent
	{
		public RegisterTimeListeners()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
