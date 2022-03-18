
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PerksScreenStaticData : IScriptable
	{
		public PerksScreenStaticData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
