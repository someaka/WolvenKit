
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InitialiseNPC : AIbehaviortaskScript
	{
		public InitialiseNPC()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
