
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioCustomEmitterMetadata : audioAudioMetadata
	{
		public audioCustomEmitterMetadata()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
