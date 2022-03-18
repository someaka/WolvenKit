
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDelaySystemEventStruct : gameDelaySystemDelayStruct
	{
		public gameDelaySystemEventStruct()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
