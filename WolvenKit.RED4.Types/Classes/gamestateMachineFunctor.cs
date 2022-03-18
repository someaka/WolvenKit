
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineFunctor : IScriptable
	{
		public gamestateMachineFunctor()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
