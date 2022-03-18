
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISignalHandlerComponent : entIComponent
	{
		public AISignalHandlerComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
