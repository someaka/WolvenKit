
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnblockAmmoDrop : gameScriptableSystemRequest
	{
		public UnblockAmmoDrop()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
