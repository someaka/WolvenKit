
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameITransactionSystem : gameIGameSystem
	{
		public gameITransactionSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
