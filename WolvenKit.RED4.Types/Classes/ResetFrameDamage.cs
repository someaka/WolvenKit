
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResetFrameDamage : redEvent
	{
		public ResetFrameDamage()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
