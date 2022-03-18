
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkScriptWeakHashMap : IScriptable
	{
		public inkScriptWeakHashMap()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
