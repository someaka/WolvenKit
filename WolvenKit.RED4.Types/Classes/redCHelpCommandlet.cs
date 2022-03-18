
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class redCHelpCommandlet : redICommandlet
	{
		public redCHelpCommandlet()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
