using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MorphTargetMeshEntry : RedBaseClass
	{
		private CName _name;
		private CName _regionName;
		private CEnum<MorphTargetsFaceRegion> _faceRegion;
		private CArray<CName> _boneNames;
		private CArray<CMatrix> _boneRigMatrices;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("regionName")] 
		public CName RegionName
		{
			get => GetProperty(ref _regionName);
			set => SetProperty(ref _regionName, value);
		}

		[Ordinal(2)] 
		[RED("faceRegion")] 
		public CEnum<MorphTargetsFaceRegion> FaceRegion
		{
			get => GetProperty(ref _faceRegion);
			set => SetProperty(ref _faceRegion, value);
		}

		[Ordinal(3)] 
		[RED("boneNames")] 
		public CArray<CName> BoneNames
		{
			get => GetProperty(ref _boneNames);
			set => SetProperty(ref _boneNames, value);
		}

		[Ordinal(4)] 
		[RED("boneRigMatrices")] 
		public CArray<CMatrix> BoneRigMatrices
		{
			get => GetProperty(ref _boneRigMatrices);
			set => SetProperty(ref _boneRigMatrices, value);
		}
	}
}
