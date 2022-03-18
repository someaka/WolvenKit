
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CSH : IScriptable
	{
		public CSH()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
