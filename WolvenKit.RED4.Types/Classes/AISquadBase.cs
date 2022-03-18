
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISquadBase : ISerializable
	{
		public AISquadBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
