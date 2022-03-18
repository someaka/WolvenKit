
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDelaySystemTickOnEventStruct : gameDelaySystemTickStruct
	{
		public gameDelaySystemTickOnEventStruct()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
