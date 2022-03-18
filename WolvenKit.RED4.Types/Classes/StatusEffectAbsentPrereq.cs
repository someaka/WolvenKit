
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatusEffectAbsentPrereq : StatusEffectPrereq
	{
		public StatusEffectAbsentPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
