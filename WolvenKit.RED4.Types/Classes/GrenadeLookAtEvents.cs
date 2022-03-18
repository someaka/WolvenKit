
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GrenadeLookAtEvents : lookAtPresetItemBaseEvents
	{
		public GrenadeLookAtEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
