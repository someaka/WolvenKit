
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IDebugConsole : RedBaseClass
	{
		public IDebugConsole()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
