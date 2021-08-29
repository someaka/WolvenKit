using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendTopologyData : RedBaseClass
	{
		private CArray<CUInt8> _data;
		private CArray<CUInt8> _metadata;
		private CUInt32 _dataStride;
		private CUInt32 _metadataStride;

		[Ordinal(0)] 
		[RED("data")] 
		public CArray<CUInt8> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(1)] 
		[RED("metadata")] 
		public CArray<CUInt8> Metadata
		{
			get => GetProperty(ref _metadata);
			set => SetProperty(ref _metadata, value);
		}

		[Ordinal(2)] 
		[RED("dataStride")] 
		public CUInt32 DataStride
		{
			get => GetProperty(ref _dataStride);
			set => SetProperty(ref _dataStride, value);
		}

		[Ordinal(3)] 
		[RED("metadataStride")] 
		public CUInt32 MetadataStride
		{
			get => GetProperty(ref _metadataStride);
			set => SetProperty(ref _metadataStride, value);
		}
	}
}
