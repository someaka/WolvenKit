
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkInputEvent : inkEvent
	{
		public inkInputEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
