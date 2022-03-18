
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GTFManager : IScriptable
	{
		public GTFManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
