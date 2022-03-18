
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkSystemServerRequesResult : inkCallbackBase
	{
		public inkSystemServerRequesResult()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
