
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MineArmEvent : redEvent
	{
		public MineArmEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
