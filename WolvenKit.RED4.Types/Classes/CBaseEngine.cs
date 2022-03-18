
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CBaseEngine : RedBaseClass
	{
		public CBaseEngine()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
