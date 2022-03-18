
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CooldownOnActivation : AICooldown
	{
		public CooldownOnActivation()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
