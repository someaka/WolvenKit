
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioEmitterMetadata : audioAudioMetadata
	{
		public audioEmitterMetadata()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
