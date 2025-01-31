using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectExecutor_Ricochet : gameEffectExecutor
	{
		[Ordinal(1)] 
		[RED("outputRicochetVector")] 
		public gameEffectOutputParameter_Vector OutputRicochetVector
		{
			get => GetPropertyValue<gameEffectOutputParameter_Vector>();
			set => SetPropertyValue<gameEffectOutputParameter_Vector>(value);
		}

		public gameEffectExecutor_Ricochet()
		{
			OutputRicochetVector = new() { BlackboardProperty = new() { SerializableID = new(), PropertyPath = new() } };
		}
	}
}
