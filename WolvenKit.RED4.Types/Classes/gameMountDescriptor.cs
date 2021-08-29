using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMountDescriptor : RedBaseClass
	{
		private entEntityID _parentId;
		private CName _slotName;
		private Transform _initialTransform;
		private CEnum<gamePuppetVehicleState> _state;
		private CEnum<gameMountDescriptorMountType> _mountType;

		[Ordinal(0)] 
		[RED("parentId")] 
		public entEntityID ParentId
		{
			get => GetProperty(ref _parentId);
			set => SetProperty(ref _parentId, value);
		}

		[Ordinal(1)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(2)] 
		[RED("initialTransform")] 
		public Transform InitialTransform
		{
			get => GetProperty(ref _initialTransform);
			set => SetProperty(ref _initialTransform, value);
		}

		[Ordinal(3)] 
		[RED("state")] 
		public CEnum<gamePuppetVehicleState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(4)] 
		[RED("mountType")] 
		public CEnum<gameMountDescriptorMountType> MountType
		{
			get => GetProperty(ref _mountType);
			set => SetProperty(ref _mountType, value);
		}
	}
}
