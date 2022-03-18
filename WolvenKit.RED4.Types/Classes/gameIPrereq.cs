
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIPrereq : IScriptable
	{
		public gameIPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
