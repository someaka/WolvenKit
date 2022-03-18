
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TogglePlayerFlashlightEffector : gameEffector
	{
		public TogglePlayerFlashlightEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
