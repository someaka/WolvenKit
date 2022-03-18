
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameScriptTaskData : IScriptable
	{
		public gameScriptTaskData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
