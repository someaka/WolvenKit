
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatPoolsManager : IScriptable
	{
		public StatPoolsManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
