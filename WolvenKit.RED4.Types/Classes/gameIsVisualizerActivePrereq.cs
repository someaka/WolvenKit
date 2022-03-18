
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIsVisualizerActivePrereq : gameIPrereq
	{
		public gameIsVisualizerActivePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
