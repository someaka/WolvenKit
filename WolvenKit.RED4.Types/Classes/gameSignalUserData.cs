
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSignalUserData : IScriptable
	{
		public gameSignalUserData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
