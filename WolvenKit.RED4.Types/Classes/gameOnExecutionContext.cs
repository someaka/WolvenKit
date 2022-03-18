
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameOnExecutionContext : RedBaseClass
	{
		public gameOnExecutionContext()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
