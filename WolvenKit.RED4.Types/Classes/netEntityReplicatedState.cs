
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class netEntityReplicatedState : netIEntityState
	{
		public netEntityReplicatedState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
