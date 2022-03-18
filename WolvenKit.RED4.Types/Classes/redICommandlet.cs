
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class redICommandlet : RedBaseClass
	{
		public redICommandlet()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
