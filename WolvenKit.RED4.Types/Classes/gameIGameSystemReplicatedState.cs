
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIGameSystemReplicatedState : ISerializable
	{
		public gameIGameSystemReplicatedState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
