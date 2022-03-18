
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UILocalizationHelper : IScriptable
	{
		public UILocalizationHelper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
