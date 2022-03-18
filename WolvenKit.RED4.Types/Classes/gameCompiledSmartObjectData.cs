
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCompiledSmartObjectData : ISerializable
	{
		public gameCompiledSmartObjectData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
