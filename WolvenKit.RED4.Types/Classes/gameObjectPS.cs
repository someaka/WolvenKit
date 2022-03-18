
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameObjectPS : gamePersistentState
	{
		public gameObjectPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
