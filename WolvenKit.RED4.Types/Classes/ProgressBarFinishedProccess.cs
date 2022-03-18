
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ProgressBarFinishedProccess : redEvent
	{
		public ProgressBarFinishedProccess()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
