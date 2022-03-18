
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GTFParamManager : IScriptable
	{
		public GTFParamManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
