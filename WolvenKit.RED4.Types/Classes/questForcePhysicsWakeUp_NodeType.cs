using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questForcePhysicsWakeUp_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		public questForcePhysicsWakeUp_NodeType()
		{
			VehicleRef = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
