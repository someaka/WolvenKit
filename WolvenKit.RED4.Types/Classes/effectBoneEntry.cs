using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class effectBoneEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("boneName")] 
		public CName BoneName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("relativePosition")] 
		public Vector3 RelativePosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(2)] 
		[RED("relativeRotation")] 
		public Quaternion RelativeRotation
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		public effectBoneEntry()
		{
			RelativePosition = new();
			RelativeRotation = new() { R = 1.000000F };
		}
	}
}
