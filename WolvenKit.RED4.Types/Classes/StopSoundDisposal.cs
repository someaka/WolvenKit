
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StopSoundDisposal : redEvent
	{
		public StopSoundDisposal()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
