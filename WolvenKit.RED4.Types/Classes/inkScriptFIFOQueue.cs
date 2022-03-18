
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkScriptFIFOQueue : IScriptable
	{
		public inkScriptFIFOQueue()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
