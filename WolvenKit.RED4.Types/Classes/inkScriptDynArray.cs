
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkScriptDynArray : IScriptable
	{
		public inkScriptDynArray()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
