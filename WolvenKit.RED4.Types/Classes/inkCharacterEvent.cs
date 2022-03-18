
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkCharacterEvent : inkInputEvent
	{
		public inkCharacterEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
