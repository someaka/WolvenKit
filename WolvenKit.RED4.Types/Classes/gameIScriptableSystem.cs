
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIScriptableSystem : IScriptable
	{
		public gameIScriptableSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
