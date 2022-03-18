
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ProgramAction : ActionBool
	{
		public ProgramAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
