
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameComponentPS : gamePersistentState
	{
		public gameComponentPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
