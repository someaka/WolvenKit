
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BountyManager : IScriptable
	{
		public BountyManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
