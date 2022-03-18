
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeInfo : IScriptable
	{
		public worldRuntimeInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
