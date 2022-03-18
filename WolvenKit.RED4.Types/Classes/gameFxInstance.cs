
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameFxInstance : IScriptable
	{
		public gameFxInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
