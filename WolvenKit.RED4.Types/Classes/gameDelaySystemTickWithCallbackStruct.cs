
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDelaySystemTickWithCallbackStruct : gameDelaySystemTickStruct
	{
		public gameDelaySystemTickWithCallbackStruct()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
