
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffector : IScriptable
	{
		public gameEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
