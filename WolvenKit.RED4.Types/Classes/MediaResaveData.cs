using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MediaResaveData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("mediaDeviceData")] 
		public MediaDeviceData MediaDeviceData
		{
			get => GetPropertyValue<MediaDeviceData>();
			set => SetPropertyValue<MediaDeviceData>(value);
		}

		public MediaResaveData()
		{
			MediaDeviceData = new();
		}
	}
}
