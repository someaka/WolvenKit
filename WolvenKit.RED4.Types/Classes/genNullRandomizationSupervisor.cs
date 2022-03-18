
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class genNullRandomizationSupervisor : genIRandomizationSupervisor
	{
		public genNullRandomizationSupervisor()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
