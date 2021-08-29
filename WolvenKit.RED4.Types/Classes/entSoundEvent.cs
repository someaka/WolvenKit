using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entSoundEvent : redEvent
	{
		private CName _eventName;
		private CArray<audioAudSwitch> _switches;
		private CArray<audioAudParameter> _params;
		private CArray<CName> _dynamicParams;

		[Ordinal(0)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetProperty(ref _eventName);
			set => SetProperty(ref _eventName, value);
		}

		[Ordinal(1)] 
		[RED("switches")] 
		public CArray<audioAudSwitch> Switches
		{
			get => GetProperty(ref _switches);
			set => SetProperty(ref _switches, value);
		}

		[Ordinal(2)] 
		[RED("params")] 
		public CArray<audioAudParameter> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		[Ordinal(3)] 
		[RED("dynamicParams")] 
		public CArray<CName> DynamicParams
		{
			get => GetProperty(ref _dynamicParams);
			set => SetProperty(ref _dynamicParams, value);
		}
	}
}
