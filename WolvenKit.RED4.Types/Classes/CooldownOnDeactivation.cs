
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CooldownOnDeactivation : AICooldown
	{
		public CooldownOnDeactivation()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
