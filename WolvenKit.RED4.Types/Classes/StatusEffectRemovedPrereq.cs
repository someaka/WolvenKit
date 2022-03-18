
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatusEffectRemovedPrereq : StatusEffectPrereq
	{
		public StatusEffectRemovedPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
