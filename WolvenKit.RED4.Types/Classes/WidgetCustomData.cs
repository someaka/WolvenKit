
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WidgetCustomData : IScriptable
	{
		public WidgetCustomData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
