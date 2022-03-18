
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CuttingGrenadeDespawnEffectsEvent : redEvent
	{
		public CuttingGrenadeDespawnEffectsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
