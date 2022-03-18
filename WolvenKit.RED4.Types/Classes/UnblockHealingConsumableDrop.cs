
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnblockHealingConsumableDrop : gameScriptableSystemRequest
	{
		public UnblockHealingConsumableDrop()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
