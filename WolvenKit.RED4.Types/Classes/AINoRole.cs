
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AINoRole : AIRole
	{
		public AINoRole()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
