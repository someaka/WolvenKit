using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsSectorEntry : RedBaseClass
	{
		private Box _sectorBounds;
		private CUInt64 _sectorHash;
		private CUInt32 _entryOffset;
		private CUInt32 _entrySize;

		[Ordinal(0)] 
		[RED("sectorBounds")] 
		public Box SectorBounds
		{
			get => GetProperty(ref _sectorBounds);
			set => SetProperty(ref _sectorBounds, value);
		}

		[Ordinal(1)] 
		[RED("sectorHash")] 
		public CUInt64 SectorHash
		{
			get => GetProperty(ref _sectorHash);
			set => SetProperty(ref _sectorHash, value);
		}

		[Ordinal(2)] 
		[RED("entryOffset")] 
		public CUInt32 EntryOffset
		{
			get => GetProperty(ref _entryOffset);
			set => SetProperty(ref _entryOffset, value);
		}

		[Ordinal(3)] 
		[RED("entrySize")] 
		public CUInt32 EntrySize
		{
			get => GetProperty(ref _entrySize);
			set => SetProperty(ref _entrySize, value);
		}
	}
}
