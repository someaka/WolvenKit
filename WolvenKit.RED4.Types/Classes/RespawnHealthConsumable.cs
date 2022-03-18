
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RespawnHealthConsumable : redEvent
	{
		public RespawnHealthConsumable()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
