using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshMeshParamUICollisionData : meshMeshParameter
	{
		private CArray<Vector2> _uvs;
		private CArray<CUInt16> _trianglesIndices;
		private CArray<Vector3> _vertices;

		[Ordinal(0)] 
		[RED("uvs")] 
		public CArray<Vector2> Uvs
		{
			get => GetProperty(ref _uvs);
			set => SetProperty(ref _uvs, value);
		}

		[Ordinal(1)] 
		[RED("trianglesIndices")] 
		public CArray<CUInt16> TrianglesIndices
		{
			get => GetProperty(ref _trianglesIndices);
			set => SetProperty(ref _trianglesIndices, value);
		}

		[Ordinal(2)] 
		[RED("vertices")] 
		public CArray<Vector3> Vertices
		{
			get => GetProperty(ref _vertices);
			set => SetProperty(ref _vertices, value);
		}
	}
}
