
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BlockAmmoDrop : gameScriptableSystemRequest
	{
		public BlockAmmoDrop()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
