
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIEnemy : ISerializable
	{
		public AIEnemy()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
