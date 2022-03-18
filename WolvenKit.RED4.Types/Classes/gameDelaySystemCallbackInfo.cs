
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDelaySystemCallbackInfo : gameDelaySystemDelayStruct
	{
		public gameDelaySystemCallbackInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
