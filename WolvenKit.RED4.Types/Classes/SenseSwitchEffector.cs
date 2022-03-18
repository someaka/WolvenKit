
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SenseSwitchEffector : gameEffector
	{
		public SenseSwitchEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
