
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldPrefabMetadata : IScriptable
	{
		public worldPrefabMetadata()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
