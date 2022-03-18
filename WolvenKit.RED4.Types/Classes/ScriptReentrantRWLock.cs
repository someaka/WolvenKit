
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScriptReentrantRWLock : RedBaseClass
	{
		public ScriptReentrantRWLock()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
