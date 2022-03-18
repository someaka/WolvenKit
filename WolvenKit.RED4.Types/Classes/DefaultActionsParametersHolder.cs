
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DefaultActionsParametersHolder : IScriptable
	{
		public DefaultActionsParametersHolder()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
