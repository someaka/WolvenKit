
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CActionScriptProxy : IScriptable
	{
		public CActionScriptProxy()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
