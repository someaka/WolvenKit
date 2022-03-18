
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ABaseWrapper : IScriptable
	{
		public ABaseWrapper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
