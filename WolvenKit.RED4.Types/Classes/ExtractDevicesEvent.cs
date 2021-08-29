using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExtractDevicesEvent : redEvent
	{
		private CArray<CHandle<gameLazyDevice>> _lazyDevices;
		private CArray<CHandle<gameDeviceComponentPS>> _devices;
		private CHandle<ProcessDevicesEvent> _eventToSendOnCompleted;
		private CInt32 _lastExtractedIndex;

		[Ordinal(0)] 
		[RED("lazyDevices")] 
		public CArray<CHandle<gameLazyDevice>> LazyDevices
		{
			get => GetProperty(ref _lazyDevices);
			set => SetProperty(ref _lazyDevices, value);
		}

		[Ordinal(1)] 
		[RED("devices")] 
		public CArray<CHandle<gameDeviceComponentPS>> Devices
		{
			get => GetProperty(ref _devices);
			set => SetProperty(ref _devices, value);
		}

		[Ordinal(2)] 
		[RED("eventToSendOnCompleted")] 
		public CHandle<ProcessDevicesEvent> EventToSendOnCompleted
		{
			get => GetProperty(ref _eventToSendOnCompleted);
			set => SetProperty(ref _eventToSendOnCompleted, value);
		}

		[Ordinal(3)] 
		[RED("lastExtractedIndex")] 
		public CInt32 LastExtractedIndex
		{
			get => GetProperty(ref _lastExtractedIndex);
			set => SetProperty(ref _lastExtractedIndex, value);
		}
	}
}
