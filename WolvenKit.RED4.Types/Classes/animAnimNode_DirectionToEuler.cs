using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_DirectionToEuler : animAnimNode_FloatValue
	{
		private animVectorLink _inputNode;
		private Vector4 _initialForwardVector;
		private CEnum<animEDirectionToEuler> _conversionType;

		[Ordinal(11)] 
		[RED("inputNode")] 
		public animVectorLink InputNode
		{
			get => GetProperty(ref _inputNode);
			set => SetProperty(ref _inputNode, value);
		}

		[Ordinal(12)] 
		[RED("initialForwardVector")] 
		public Vector4 InitialForwardVector
		{
			get => GetProperty(ref _initialForwardVector);
			set => SetProperty(ref _initialForwardVector, value);
		}

		[Ordinal(13)] 
		[RED("conversionType")] 
		public CEnum<animEDirectionToEuler> ConversionType
		{
			get => GetProperty(ref _conversionType);
			set => SetProperty(ref _conversionType, value);
		}
	}
}
