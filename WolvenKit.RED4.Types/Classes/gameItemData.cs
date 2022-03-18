
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameItemData : IScriptable
	{
		public gameItemData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
