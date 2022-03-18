
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BlockHealingConsumableDrop : gameScriptableSystemRequest
	{
		public BlockHealingConsumableDrop()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
