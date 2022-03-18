
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDelaySystemPSEventStruct : gameDelaySystemDelayStruct
	{
		public gameDelaySystemPSEventStruct()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
