
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkSaveTransferRequestUpdate : inkCallbackBase
	{
		public inkSaveTransferRequestUpdate()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
