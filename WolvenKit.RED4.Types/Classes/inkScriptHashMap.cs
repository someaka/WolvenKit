
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkScriptHashMap : IScriptable
	{
		public inkScriptHashMap()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
