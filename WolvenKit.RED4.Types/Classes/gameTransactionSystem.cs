
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTransactionSystem : gameITransactionSystem
	{
		public gameTransactionSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
