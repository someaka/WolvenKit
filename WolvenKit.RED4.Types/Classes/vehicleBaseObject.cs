using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleBaseObject : gameObject
	{
		private CResourceReference<AIArchetype> _archetype;
		private CWeakHandle<VehicleComponent> _vehicleComponent;
		private CWeakHandle<WorldWidgetComponent> _uiComponent;
		private CHandle<CrowdMemberBaseComponent> _crowdMemberComponent;
		private CFloat _hitTimestamp;
		private CName _drivingTrafficPattern;
		private CBool _onPavement;
		private CBool _inTrafficLane;
		private CInt32 _timesSentReactionEvent;
		private CBool _vehicleUpsideDown;

		[Ordinal(40)] 
		[RED("archetype")] 
		public CResourceReference<AIArchetype> Archetype
		{
			get => GetProperty(ref _archetype);
			set => SetProperty(ref _archetype, value);
		}

		[Ordinal(41)] 
		[RED("vehicleComponent")] 
		public CWeakHandle<VehicleComponent> VehicleComponent
		{
			get => GetProperty(ref _vehicleComponent);
			set => SetProperty(ref _vehicleComponent, value);
		}

		[Ordinal(42)] 
		[RED("uiComponent")] 
		public CWeakHandle<WorldWidgetComponent> UiComponent
		{
			get => GetProperty(ref _uiComponent);
			set => SetProperty(ref _uiComponent, value);
		}

		[Ordinal(43)] 
		[RED("crowdMemberComponent")] 
		public CHandle<CrowdMemberBaseComponent> CrowdMemberComponent
		{
			get => GetProperty(ref _crowdMemberComponent);
			set => SetProperty(ref _crowdMemberComponent, value);
		}

		[Ordinal(44)] 
		[RED("hitTimestamp")] 
		public CFloat HitTimestamp
		{
			get => GetProperty(ref _hitTimestamp);
			set => SetProperty(ref _hitTimestamp, value);
		}

		[Ordinal(45)] 
		[RED("drivingTrafficPattern")] 
		public CName DrivingTrafficPattern
		{
			get => GetProperty(ref _drivingTrafficPattern);
			set => SetProperty(ref _drivingTrafficPattern, value);
		}

		[Ordinal(46)] 
		[RED("onPavement")] 
		public CBool OnPavement
		{
			get => GetProperty(ref _onPavement);
			set => SetProperty(ref _onPavement, value);
		}

		[Ordinal(47)] 
		[RED("inTrafficLane")] 
		public CBool InTrafficLane
		{
			get => GetProperty(ref _inTrafficLane);
			set => SetProperty(ref _inTrafficLane, value);
		}

		[Ordinal(48)] 
		[RED("timesSentReactionEvent")] 
		public CInt32 TimesSentReactionEvent
		{
			get => GetProperty(ref _timesSentReactionEvent);
			set => SetProperty(ref _timesSentReactionEvent, value);
		}

		[Ordinal(49)] 
		[RED("vehicleUpsideDown")] 
		public CBool VehicleUpsideDown
		{
			get => GetProperty(ref _vehicleUpsideDown);
			set => SetProperty(ref _vehicleUpsideDown, value);
		}
	}
}
