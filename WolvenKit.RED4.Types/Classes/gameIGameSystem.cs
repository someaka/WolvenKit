
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIGameSystem : IScriptable
	{
		public gameIGameSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
