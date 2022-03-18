
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameBaseTimer : IScriptable
	{
		public gameBaseTimer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
