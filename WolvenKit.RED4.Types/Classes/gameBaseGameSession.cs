
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameBaseGameSession : RedBaseClass
	{
		public gameBaseGameSession()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
