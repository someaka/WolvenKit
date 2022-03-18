
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PipelineProcessedCallback : HitCallback
	{
		public PipelineProcessedCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
