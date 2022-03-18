
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class genScriptedRandomizationSupervisor : genIRandomizationSupervisor
	{
		public genScriptedRandomizationSupervisor()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
