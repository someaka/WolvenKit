
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkMenuEventDispatcher : IScriptable
	{
		public inkMenuEventDispatcher()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
