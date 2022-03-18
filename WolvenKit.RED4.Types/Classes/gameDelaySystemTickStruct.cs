
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDelaySystemTickStruct : ISerializable
	{
		public gameDelaySystemTickStruct()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
