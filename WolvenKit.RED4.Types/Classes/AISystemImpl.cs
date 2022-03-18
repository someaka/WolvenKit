
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISystemImpl : AIISystem
	{
		public AISystemImpl()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
